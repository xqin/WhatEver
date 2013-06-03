using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections;

namespace WhatEver{
    public partial class WhatEver : Form{
        private const string Config_File = "XConfig.xml";
        private XmlManager Xml;

        public WhatEver(){
            InitializeComponent();
            this.Icon = this.IT.Icon = GetFileIcon(Application.ExecutablePath);
        }

        public static System.Drawing.Icon GetFileIcon(string name){
            Shell32.SHFILEINFO shfi = new Shell32.SHFILEINFO();
            uint flags = Shell32.SHGFI_ICON | Shell32.SHGFI_USEFILEATTRIBUTES | Shell32.SHGFI_SMALLICON;

            Shell32.SHGetFileInfo( name,
                Shell32.FILE_ATTRIBUTE_NORMAL,
                ref shfi,
                (uint) System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                flags );


            System.Drawing.Icon icon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shfi.hIcon).Clone();
            User32.DestroyIcon( shfi.hIcon );
            return icon;
        }

        private void EnableProxy_CheckedChanged(object sender, EventArgs e){
            SkipLocalProxy.Enabled = EnableProxy.Checked;
            IEServerSetting.Enabled = EnableProxy.Checked;
            IEExceptSetting.Enabled = EnableProxy.Checked;
        }

        private void WhatEver_Load(object sender, EventArgs e){
            if (File.Exists(Config_File) == false){
                File.WriteAllText(Config_File, "<?xml version=\"1.0\" encoding=\"UTF-8\"?><Config></Config>", Encoding.UTF8);
            }
            Xml = new XmlManager(Config_File);
            LoadConfigToOption();
        }
        private void LoadConfigToOption(){
            ArrayList st = Xml.getAllSettingList();
            ConfigList.Items.Clear();
            ProxyList.DropDownItems.Clear();
            foreach (string[] s in st){
                ConfigList.Items.Add(new SettingItem(s));
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Name = s[0];
                item.Text = s[1];
                item.Click += new EventHandler(this.proxyItem_Click);
                ProxyList.DropDownItems.Add(item);
            }
        }

        private void proxyItem_Click(object sender, EventArgs e){
            applySetting(((ToolStripMenuItem)sender).Name);
            foreach (ToolStripMenuItem item in this.ProxyList.DropDownItems){
                item.Checked = false;
            }
            ((ToolStripMenuItem)sender).Checked = true;
            MessageBox.Show("应用配置成功!");
        }

        private void SaveAsSetting_Click(object sender, EventArgs e){
            string name = ShowDialog("", "请输入配置方案名称");
            if (name == "") return;
            string guid = string.Format("{{{0}}}", Guid.NewGuid().ToString());
            Xml.addNewSetting(name, guid, new string[]{
                this.EnableProxy.Checked?"1":"0", getProxyServer(), getProxyOverride(), HostContent.Text
            });
            LoadConfigToOption();
            MessageBox.Show("保存成功!");
        }

        private string getProxyOverride(){
            if (this.EnableProxy.Checked == false){
                return "";
            }
            return this.ProxyOverride.Text + (SkipLocalProxy.Checked ? ";<local>" : "");
        }

        private string getProxyServer(){
            if (this.EnableProxy.Checked == false){
                return "";
            }
            if (UseAllSameSetting.Checked){
                return string.Format("{0}:{1}", HTTP_IP.Text, HTTP_Port.Text);
            }
            ArrayList ret = new ArrayList();

            if (HTTP_IP.Text != ""){
                ret.Add("http=" + HTTP_IP.Text + (HTTP_Port.Text != "" ? ":" + HTTP_Port.Text : ""));
            }
            if (HTTPS_IP.Text != ""){
                ret.Add("https=" + HTTPS_IP.Text + (HTTPS_Port.Text != "" ? ":" + HTTPS_Port.Text : ""));
            }
            if (FTP_IP.Text != ""){
                ret.Add("ftp=" + FTP_IP.Text + (FTP_Port.Text != "" ? ":" + FTP_Port.Text : ""));
            }
            if (SOCKS_IP.Text != ""){
                ret.Add("socks=" + SOCKS_IP.Text + (SOCKS_Port.Text != "" ? ":" + SOCKS_Port.Text : ""));
            }
            return string.Join(";", (string[])ret.ToArray(typeof(string)));
        }

        private void ConfigList_SelectedIndexChanged(object sender, EventArgs e){
            SettingItem st = (SettingItem)ConfigList.SelectedItem;
            Hashtable ret = Xml.getSettingById(st.Id);
            if (ret == null) return;
            if ((string)ret["ProxyEnable"] == "1"){
                EnableProxy.Checked = true;
                if (((string)ret["ProxyServer"]).IndexOf("=") == -1){
                    UseAllSameSetting.Checked = true;
                    string[] proxy = ((string)ret["ProxyServer"]).Split(':');
                    HTTP_IP.Text = proxy[0];
                    HTTP_Port.Text = proxy[1];
                }else{
                    string[] proxys = ((string)ret["ProxyServer"]).Split(';');
                    foreach (string p in proxys){
                        string[] proxy = p.Split('=');
                        string[] sett = proxy[1].Split(':');
                        switch (proxy[0].ToUpper()){
                            case "HTTP":
                                HTTP_IP.Text = sett[0];
                                HTTP_Port.Text = sett[1];
                                break;
                            case "HTTPS":
                                HTTPS_IP.Text = sett[0];
                                HTTPS_Port.Text = sett[1];
                                break;
                            case "FTP":
                                FTP_IP.Text = sett[0];
                                FTP_Port.Text = sett[1];
                                break;
                            case "SOCKS":
                                SOCKS_IP.Text = sett[0];
                                SOCKS_Port.Text = sett[1];
                                break;
                        }
                    }
                }
                if (((string)ret["ProxyOverride"]).IndexOf("<local>") != -1){
                    SkipLocalProxy.Checked = true;
                }
            }else{
                EnableProxy.Checked = false;
            }
            ProxyOverride.Text = ((string)ret["ProxyOverride"]).Replace("<local>", "");
            HostContent.Text = (string)ret["Hosts"];

            SaveSetting.Enabled = true;
            ApplySetting.Enabled = true;
        }

        private void UseAllSameSetting_CheckedChanged(object sender, EventArgs e){
            HTTPS_IP.Enabled = HTTPS_Port.Enabled = FTP_IP.Enabled = FTP_Port.Enabled = SOCKS_IP.Enabled = SOCKS_Port.Enabled = !UseAllSameSetting.Checked;
        }

        private void SaveSetting_Click(object sender, EventArgs e){
            SaveConfig();
            MessageBox.Show("保存成功!");
        }
        private void SaveConfig(){
            SettingItem st = (SettingItem)ConfigList.SelectedItem;
            Xml.saveSetting(st.Id, new string[]{
                this.EnableProxy.Checked?"1":"0", getProxyServer(), getProxyOverride(), HostContent.Text
            });
        }

        private void ApplySetting_Click(object sender, EventArgs e){
            SaveConfig();
            SettingItem st = (SettingItem)ConfigList.SelectedItem;
            applySetting(st.Id);
            MessageBox.Show("应用成功!");
        }

        private void applySetting(string id){
            Hashtable ret = Xml.getSettingById(id);
            if (ret == null) return;
            Proxies.SetProxy((string)ret["ProxyServer"], (string)ret["ProxyOverride"]);
            string file = Environment.GetEnvironmentVariable("SystemRoot") + @"\system32\drivers\etc\hosts";
            string txt = File.ReadAllText(file, Encoding.Default);
            txt = Regex.Replace(txt, @"#WhatEver Start[\s\S]+?#WhatEver End\r\n", "");
            string host = ((string)ret["Hosts"]);
            //把Hosts放在 hosts文件的最上面,优先级最高
            File.WriteAllText(file, string.Format("#WhatEver Start\r\n{0}\r\n#WhatEver End\r\n{1}", host, txt), Encoding.Default);
        }

        private void ShareConfig_Click(object sender, EventArgs e){
            SaveConfig();
            SettingItem st = (SettingItem)ConfigList.SelectedItem;
            Hashtable ret = Xml.getSettingById(st.Id);
            if (ret == null) return;
            ret.Add("Name", st.Name);
            Clipboard.SetDataObject(Convert.ToBase64String(Encoding.UTF8.GetBytes(JSON.Encode(ret))));
            MessageBox.Show("当前的配置信息已经保存到剪贴板了,发给好友分享吧!");
        }

        private void getShareConfig_Click(object sender, EventArgs e){
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text)){
                try{
                    Hashtable config = (Hashtable)JSON.Decode(Encoding.UTF8.GetString(Convert.FromBase64String((String)iData.GetData(DataFormats.Text))));
                    string guid = string.Format("{{{0}}}", Guid.NewGuid().ToString());
                    Xml.addNewSetting((string)config["Name"], guid, new string[]{
                        (string)config["ProxyEnable"], (string)config["ProxyServer"], (string)config["ProxyOverride"], (string)config["Hosts"]
                    });
                    LoadConfigToOption();
                    Clipboard.SetDataObject("");
                    MessageBox.Show("保存成功!");
                }catch{ }
            }
        }

        private void WhatEver_SizeChanged(object sender, EventArgs e){
            if (this.WindowState == FormWindowState.Minimized){
                this.Hide();
            }
        }

        private void IT_MouseDoubleClick(object sender, MouseEventArgs e){
            if (this.WindowState == FormWindowState.Minimized){
                this.Show();
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void 退出EToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }

        private void 关闭代理CToolStripMenuItem_Click(object sender, EventArgs e){
            Proxies.UnsetProxy();
            MessageBox.Show("代理关闭成功!");
        }

        private Form prompt;
        private TextBox textBox;
        private string ShowDialog(string text, string caption){
            prompt = new Form();
            prompt.Width = 450;
            prompt.Height = 165;
            prompt.Text = caption;
            prompt.MaximumSize = new Size(450, 165);
            prompt.MinimumSize = new Size(450, 165);
            prompt.MaximizeBox = false;
            prompt.MinimizeBox = false;
            prompt.TopMost = true;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            textBox = new TextBox();
            textBox.Left = 50;
            textBox.Top = 50;
            textBox.Width = 350;
            textBox.TabIndex = 0;

            Button confirmation = new Button();
            confirmation.Text = "Ok";
            confirmation.Left = 300;
            confirmation.Width = 100;
            confirmation.Top = 80;
            confirmation.Click += new System.EventHandler(ConfrimPrompt);
            Button CloseBtn = new Button();
            CloseBtn.Click += new System.EventHandler(ClosePrompt);

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textBox);
            prompt.ShowIcon = false;
            prompt.AcceptButton = confirmation;
            prompt.CancelButton  = CloseBtn;
            prompt.ActiveControl = textBox;
            prompt.Activate();
            textBox.Focus();
            prompt.ShowDialog();
            return textBox.Text;
        }

        private void ConfrimPrompt(object sender, EventArgs e){
            prompt.Close();
        }

        private void ClosePrompt(object sender, EventArgs e){
            textBox.Text = "";
            prompt.Close();
        }

        [STAThread]
        static void Main(){
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WhatEver());
        }

    }

    class SettingItem{
        private string _Id, _Name;
        public string Id { get{return this._Id;} set{this._Id = value;} }
        public string Name { get{return this._Name;} set{this._Name = value;} }

        public SettingItem(string[] Setting){
            Id = Setting[0];
            Name = Setting[1];
        }
        public override string ToString(){
            return Name;
        }
    }

    class XmlManager{
        private XmlDocument XmlDoc;
        private XmlNode Root;
        private string XmlFile;
        private string[] Nodes = new string[]{
            "ProxyEnable",
            "ProxyServer",
            "ProxyOverride",
            "Hosts"
        };
        public XmlManager(string file){
            try{
                XmlFile = file;
                XmlDoc = new XmlDocument();
                XmlDoc.Load(XmlFile);
                Root = XmlDoc.SelectSingleNode("Config");
                if (Root.Equals(null)){
                    throw new Exception("Xml文件格式不正确!");
                }
            } catch(Exception ex){
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }

        public ArrayList getAllSettingList(){
            XmlNodeList list = Root.SelectNodes("Settings");
            ArrayList ret = new ArrayList();
            foreach (XmlNode node in list){
                try{
                    ret.Add(new string[]{node.Attributes["Id"].Value, node.Attributes["Name"].Value});
                }catch{ }
            }
            return ret;
        }

        public Hashtable getSettingById(string id){
            XmlNode node = Root.SelectSingleNode(string.Format("//Settings[@Id='{0}']", id));
            if (node == null) return null;
            Hashtable ret = new Hashtable();
            foreach (string key in Nodes){
                ret.Add(key, getNodeValue(node, key));
            }
            return ret;
        }

        private string getNodeValue(XmlNode node, string p){
            XmlNode nd = node.SelectSingleNode(p);
            if (nd == null) return "";
            return nd.InnerText;
        }

        public void saveSetting(string id, string[] config){
            XmlNode node = Root.SelectSingleNode(string.Format("//Settings[@Id='{0}']", id)), n;
            if (node == null) return;
            
            int i = 0;

            foreach (string key in Nodes){
                n = node.SelectSingleNode(key);
                if (n == null){
                    i++;
                    continue;
                }
                n.InnerXml = string.Format("<![CDATA[{0}]]>", config[i++]);
            }
            XmlDoc.Save(XmlFile);
        }
        public void addNewSetting(string name, string guid, string[] config){
            XmlElement st = XmlDoc.CreateElement("Settings"), n;
            st.SetAttribute("Name", name);
            st.SetAttribute("Id", guid);

            int i = 0;

            foreach (string key in Nodes){
                n = XmlDoc.CreateElement(key);
                n.AppendChild(XmlDoc.CreateCDataSection(config[i++]));
                st.AppendChild(n);
            }

            Root.AppendChild(st);

            XmlDoc.Save(XmlFile);
        }
    }
}