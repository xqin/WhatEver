namespace WhatEver
{
    partial class WhatEver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatEver));
            this.label1 = new System.Windows.Forms.Label();
            this.ConfigList = new System.Windows.Forms.ComboBox();
            this.ApplySetting = new System.Windows.Forms.Button();
            this.SaveAsSetting = new System.Windows.Forms.Button();
            this.SaveSetting = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.TabControl();
            this.IESetting = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IEExceptSetting = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ProxyOverride = new System.Windows.Forms.TextBox();
            this.IEServerSetting = new System.Windows.Forms.GroupBox();
            this.SOCKS_Port = new System.Windows.Forms.TextBox();
            this.SOCKS_IP = new System.Windows.Forms.TextBox();
            this.FTP_Port = new System.Windows.Forms.TextBox();
            this.HTTPS_Port = new System.Windows.Forms.TextBox();
            this.FTP_IP = new System.Windows.Forms.TextBox();
            this.HTTP_Port = new System.Windows.Forms.TextBox();
            this.HTTPS_IP = new System.Windows.Forms.TextBox();
            this.HTTP_IP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UseAllSameSetting = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SkipLocalProxy = new System.Windows.Forms.CheckBox();
            this.EnableProxy = new System.Windows.Forms.CheckBox();
            this.HostsSetting = new System.Windows.Forms.TabPage();
            this.HostContent = new System.Windows.Forms.TextBox();
            this.ShareConfig = new System.Windows.Forms.Button();
            this.getShareConfig = new System.Windows.Forms.Button();
            this.IT = new System.Windows.Forms.NotifyIcon(this.components);
            this.IMemu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ProxyList = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭代理CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings.SuspendLayout();
            this.IESetting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.IEExceptSetting.SuspendLayout();
            this.IEServerSetting.SuspendLayout();
            this.HostsSetting.SuspendLayout();
            this.IMemu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "配置列表:";
            // 
            // ConfigList
            // 
            this.ConfigList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConfigList.FormattingEnabled = true;
            this.ConfigList.Location = new System.Drawing.Point(79, 17);
            this.ConfigList.Name = "ConfigList";
            this.ConfigList.Size = new System.Drawing.Size(184, 20);
            this.ConfigList.TabIndex = 1;
            this.ConfigList.SelectedIndexChanged += new System.EventHandler(this.ConfigList_SelectedIndexChanged);
            // 
            // ApplySetting
            // 
            this.ApplySetting.Enabled = false;
            this.ApplySetting.Location = new System.Drawing.Point(269, 9);
            this.ApplySetting.Name = "ApplySetting";
            this.ApplySetting.Size = new System.Drawing.Size(60, 21);
            this.ApplySetting.TabIndex = 2;
            this.ApplySetting.Text = "应用(&A)";
            this.ApplySetting.UseVisualStyleBackColor = true;
            this.ApplySetting.Click += new System.EventHandler(this.ApplySetting_Click);
            // 
            // SaveAsSetting
            // 
            this.SaveAsSetting.Location = new System.Drawing.Point(406, 9);
            this.SaveAsSetting.Name = "SaveAsSetting";
            this.SaveAsSetting.Size = new System.Drawing.Size(67, 21);
            this.SaveAsSetting.TabIndex = 3;
            this.SaveAsSetting.Text = "另存为(&O)";
            this.SaveAsSetting.UseVisualStyleBackColor = true;
            this.SaveAsSetting.Click += new System.EventHandler(this.SaveAsSetting_Click);
            // 
            // SaveSetting
            // 
            this.SaveSetting.Enabled = false;
            this.SaveSetting.Location = new System.Drawing.Point(337, 9);
            this.SaveSetting.Name = "SaveSetting";
            this.SaveSetting.Size = new System.Drawing.Size(60, 21);
            this.SaveSetting.TabIndex = 4;
            this.SaveSetting.Text = "保存(&S)";
            this.SaveSetting.UseVisualStyleBackColor = true;
            this.SaveSetting.Click += new System.EventHandler(this.SaveSetting_Click);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.IESetting);
            this.Settings.Controls.Add(this.HostsSetting);
            this.Settings.Location = new System.Drawing.Point(12, 50);
            this.Settings.Name = "Settings";
            this.Settings.SelectedIndex = 0;
            this.Settings.Size = new System.Drawing.Size(465, 582);
            this.Settings.TabIndex = 5;
            // 
            // IESetting
            // 
            this.IESetting.Controls.Add(this.groupBox1);
            this.IESetting.Location = new System.Drawing.Point(4, 22);
            this.IESetting.Name = "IESetting";
            this.IESetting.Padding = new System.Windows.Forms.Padding(3);
            this.IESetting.Size = new System.Drawing.Size(457, 556);
            this.IESetting.TabIndex = 0;
            this.IESetting.Text = "IE代理设置";
            this.IESetting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IEExceptSetting);
            this.groupBox1.Controls.Add(this.IEServerSetting);
            this.groupBox1.Controls.Add(this.SkipLocalProxy);
            this.groupBox1.Controls.Add(this.EnableProxy);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代理服务器设置";
            // 
            // IEExceptSetting
            // 
            this.IEExceptSetting.Controls.Add(this.label14);
            this.IEExceptSetting.Controls.Add(this.label13);
            this.IEExceptSetting.Controls.Add(this.ProxyOverride);
            this.IEExceptSetting.Enabled = false;
            this.IEExceptSetting.Location = new System.Drawing.Point(6, 288);
            this.IEExceptSetting.Name = "IEExceptSetting";
            this.IEExceptSetting.Size = new System.Drawing.Size(424, 247);
            this.IEExceptSetting.TabIndex = 3;
            this.IEExceptSetting.TabStop = false;
            this.IEExceptSetting.Text = "例外";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "可以使用分号(;)逗号(,)及一行一个来分隔各项.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "对于下列字符开关的地址不使用代理服务器(&N)";
            // 
            // ProxyOverride
            // 
            this.ProxyOverride.Location = new System.Drawing.Point(6, 42);
            this.ProxyOverride.Multiline = true;
            this.ProxyOverride.Name = "ProxyOverride";
            this.ProxyOverride.Size = new System.Drawing.Size(406, 174);
            this.ProxyOverride.TabIndex = 108;
            // 
            // IEServerSetting
            // 
            this.IEServerSetting.Controls.Add(this.SOCKS_Port);
            this.IEServerSetting.Controls.Add(this.SOCKS_IP);
            this.IEServerSetting.Controls.Add(this.FTP_Port);
            this.IEServerSetting.Controls.Add(this.HTTPS_Port);
            this.IEServerSetting.Controls.Add(this.FTP_IP);
            this.IEServerSetting.Controls.Add(this.HTTP_Port);
            this.IEServerSetting.Controls.Add(this.HTTPS_IP);
            this.IEServerSetting.Controls.Add(this.HTTP_IP);
            this.IEServerSetting.Controls.Add(this.label8);
            this.IEServerSetting.Controls.Add(this.UseAllSameSetting);
            this.IEServerSetting.Controls.Add(this.label7);
            this.IEServerSetting.Controls.Add(this.label6);
            this.IEServerSetting.Controls.Add(this.label5);
            this.IEServerSetting.Controls.Add(this.label4);
            this.IEServerSetting.Controls.Add(this.label12);
            this.IEServerSetting.Controls.Add(this.label11);
            this.IEServerSetting.Controls.Add(this.label10);
            this.IEServerSetting.Controls.Add(this.label9);
            this.IEServerSetting.Controls.Add(this.label3);
            this.IEServerSetting.Controls.Add(this.label2);
            this.IEServerSetting.Enabled = false;
            this.IEServerSetting.Location = new System.Drawing.Point(6, 58);
            this.IEServerSetting.Name = "IEServerSetting";
            this.IEServerSetting.Size = new System.Drawing.Size(424, 224);
            this.IEServerSetting.TabIndex = 2;
            this.IEServerSetting.TabStop = false;
            this.IEServerSetting.Text = "服务器";
            // 
            // SOCKS_Port
            // 
            this.SOCKS_Port.Location = new System.Drawing.Point(321, 145);
            this.SOCKS_Port.MaxLength = 5;
            this.SOCKS_Port.Name = "SOCKS_Port";
            this.SOCKS_Port.Size = new System.Drawing.Size(60, 21);
            this.SOCKS_Port.TabIndex = 106;
            // 
            // SOCKS_IP
            // 
            this.SOCKS_IP.Location = new System.Drawing.Point(115, 145);
            this.SOCKS_IP.Name = "SOCKS_IP";
            this.SOCKS_IP.Size = new System.Drawing.Size(180, 21);
            this.SOCKS_IP.TabIndex = 105;
            // 
            // FTP_Port
            // 
            this.FTP_Port.Location = new System.Drawing.Point(321, 112);
            this.FTP_Port.MaxLength = 5;
            this.FTP_Port.Name = "FTP_Port";
            this.FTP_Port.Size = new System.Drawing.Size(60, 21);
            this.FTP_Port.TabIndex = 104;
            // 
            // HTTPS_Port
            // 
            this.HTTPS_Port.Location = new System.Drawing.Point(321, 79);
            this.HTTPS_Port.MaxLength = 5;
            this.HTTPS_Port.Name = "HTTPS_Port";
            this.HTTPS_Port.Size = new System.Drawing.Size(60, 21);
            this.HTTPS_Port.TabIndex = 102;
            // 
            // FTP_IP
            // 
            this.FTP_IP.Location = new System.Drawing.Point(115, 112);
            this.FTP_IP.Name = "FTP_IP";
            this.FTP_IP.Size = new System.Drawing.Size(180, 21);
            this.FTP_IP.TabIndex = 103;
            // 
            // HTTP_Port
            // 
            this.HTTP_Port.Location = new System.Drawing.Point(321, 50);
            this.HTTP_Port.MaxLength = 5;
            this.HTTP_Port.Name = "HTTP_Port";
            this.HTTP_Port.Size = new System.Drawing.Size(60, 21);
            this.HTTP_Port.TabIndex = 100;
            // 
            // HTTPS_IP
            // 
            this.HTTPS_IP.Location = new System.Drawing.Point(115, 79);
            this.HTTPS_IP.Name = "HTTPS_IP";
            this.HTTPS_IP.Size = new System.Drawing.Size(180, 21);
            this.HTTPS_IP.TabIndex = 101;
            // 
            // HTTP_IP
            // 
            this.HTTP_IP.Location = new System.Drawing.Point(115, 50);
            this.HTTP_IP.Name = "HTTP_IP";
            this.HTTP_IP.Size = new System.Drawing.Size(180, 21);
            this.HTTP_IP.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "端口";
            // 
            // UseAllSameSetting
            // 
            this.UseAllSameSetting.AutoSize = true;
            this.UseAllSameSetting.Location = new System.Drawing.Point(78, 192);
            this.UseAllSameSetting.Name = "UseAllSameSetting";
            this.UseAllSameSetting.Size = new System.Drawing.Size(234, 16);
            this.UseAllSameSetting.TabIndex = 107;
            this.UseAllSameSetting.Text = "对所有协议均使用相同的代理服务器(&U)";
            this.UseAllSameSetting.UseVisualStyleBackColor = true;
            this.UseAllSameSetting.CheckedChanged += new System.EventHandler(this.UseAllSameSetting_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Socks(&C):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "FTP(&F):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "HTTPS(&S):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "HTTP(&H):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "要使用的代理服务器地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "类型";
            // 
            // SkipLocalProxy
            // 
            this.SkipLocalProxy.AutoSize = true;
            this.SkipLocalProxy.Enabled = false;
            this.SkipLocalProxy.Location = new System.Drawing.Point(236, 24);
            this.SkipLocalProxy.Name = "SkipLocalProxy";
            this.SkipLocalProxy.Size = new System.Drawing.Size(168, 16);
            this.SkipLocalProxy.TabIndex = 98;
            this.SkipLocalProxy.Text = "跳过本地地址的代理服务器";
            this.SkipLocalProxy.UseVisualStyleBackColor = true;
            // 
            // EnableProxy
            // 
            this.EnableProxy.AutoSize = true;
            this.EnableProxy.Location = new System.Drawing.Point(29, 24);
            this.EnableProxy.Name = "EnableProxy";
            this.EnableProxy.Size = new System.Drawing.Size(150, 16);
            this.EnableProxy.TabIndex = 97;
            this.EnableProxy.Text = "为 LAN 使用代理服务器";
            this.EnableProxy.UseVisualStyleBackColor = true;
            this.EnableProxy.CheckedChanged += new System.EventHandler(this.EnableProxy_CheckedChanged);
            // 
            // HostsSetting
            // 
            this.HostsSetting.Controls.Add(this.HostContent);
            this.HostsSetting.Location = new System.Drawing.Point(4, 22);
            this.HostsSetting.Name = "HostsSetting";
            this.HostsSetting.Padding = new System.Windows.Forms.Padding(3);
            this.HostsSetting.Size = new System.Drawing.Size(457, 556);
            this.HostsSetting.TabIndex = 1;
            this.HostsSetting.Text = "Hosts配置";
            this.HostsSetting.UseVisualStyleBackColor = true;
            // 
            // HostContent
            // 
            this.HostContent.Location = new System.Drawing.Point(6, 6);
            this.HostContent.Multiline = true;
            this.HostContent.Name = "HostContent";
            this.HostContent.Size = new System.Drawing.Size(445, 544);
            this.HostContent.TabIndex = 0;
            // 
            // ShareConfig
            // 
            this.ShareConfig.Location = new System.Drawing.Point(269, 36);
            this.ShareConfig.Name = "ShareConfig";
            this.ShareConfig.Size = new System.Drawing.Size(92, 21);
            this.ShareConfig.TabIndex = 6;
            this.ShareConfig.Text = "分享当前配置";
            this.ShareConfig.UseVisualStyleBackColor = true;
            this.ShareConfig.Click += new System.EventHandler(this.ShareConfig_Click);
            // 
            // getShareConfig
            // 
            this.getShareConfig.Location = new System.Drawing.Point(372, 37);
            this.getShareConfig.Name = "getShareConfig";
            this.getShareConfig.Size = new System.Drawing.Size(101, 21);
            this.getShareConfig.TabIndex = 7;
            this.getShareConfig.Text = "导入分享的配置";
            this.getShareConfig.UseVisualStyleBackColor = true;
            this.getShareConfig.Click += new System.EventHandler(this.getShareConfig_Click);
            // 
            // IT
            // 
            this.IT.ContextMenuStrip = this.IMemu;
            //this.IT.Icon = ((System.Drawing.Icon)(resources.GetObject("IT.Icon")));
            this.IT.Visible = true;
            this.IT.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.IT_MouseDoubleClick);
            // 
            // IMemu
            // 
            this.IMemu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProxyList,
            this.关闭代理CToolStripMenuItem,
            this.退出EToolStripMenuItem});
            this.IMemu.Name = "IMemu";
            this.IMemu.Size = new System.Drawing.Size(139, 70);
            // 
            // ProxyList
            // 
            this.ProxyList.Name = "ProxyList";
            this.ProxyList.Size = new System.Drawing.Size(138, 22);
            this.ProxyList.Text = "配置列表(&L)";
            // 
            // 关闭代理CToolStripMenuItem
            // 
            this.关闭代理CToolStripMenuItem.Name = "关闭代理CToolStripMenuItem";
            this.关闭代理CToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.关闭代理CToolStripMenuItem.Text = "关闭代理(&C)";
            this.关闭代理CToolStripMenuItem.Click += new System.EventHandler(this.关闭代理CToolStripMenuItem_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // WhatEver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 644);
            this.Controls.Add(this.getShareConfig);
            this.Controls.Add(this.ShareConfig);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.SaveSetting);
            this.Controls.Add(this.SaveAsSetting);
            this.Controls.Add(this.ApplySetting);
            this.Controls.Add(this.ConfigList);
            this.Controls.Add(this.label1);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 678);
            this.MinimumSize = new System.Drawing.Size(501, 678);
            this.Name = "WhatEver";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IE代理及Hosts配置自动化工具";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.WhatEver_Load);
            this.SizeChanged += new System.EventHandler(this.WhatEver_SizeChanged);
            this.Settings.ResumeLayout(false);
            this.IESetting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.IEExceptSetting.ResumeLayout(false);
            this.IEExceptSetting.PerformLayout();
            this.IEServerSetting.ResumeLayout(false);
            this.IEServerSetting.PerformLayout();
            this.HostsSetting.ResumeLayout(false);
            this.HostsSetting.PerformLayout();
            this.IMemu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ConfigList;
        private System.Windows.Forms.Button ApplySetting;
        private System.Windows.Forms.Button SaveAsSetting;
        private System.Windows.Forms.Button SaveSetting;
        private System.Windows.Forms.TabControl Settings;
        private System.Windows.Forms.TabPage IESetting;
        private System.Windows.Forms.TabPage HostsSetting;
        private System.Windows.Forms.TextBox HostContent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SkipLocalProxy;
        private System.Windows.Forms.CheckBox EnableProxy;
        private System.Windows.Forms.GroupBox IEExceptSetting;
        private System.Windows.Forms.GroupBox IEServerSetting;
        private System.Windows.Forms.TextBox SOCKS_Port;
        private System.Windows.Forms.TextBox SOCKS_IP;
        private System.Windows.Forms.TextBox FTP_Port;
        private System.Windows.Forms.TextBox HTTPS_Port;
        private System.Windows.Forms.TextBox FTP_IP;
        private System.Windows.Forms.TextBox HTTP_Port;
        private System.Windows.Forms.TextBox HTTPS_IP;
        private System.Windows.Forms.TextBox HTTP_IP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox UseAllSameSetting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ProxyOverride;
        private System.Windows.Forms.Button ShareConfig;
        private System.Windows.Forms.Button getShareConfig;
        private System.Windows.Forms.NotifyIcon IT;
        private System.Windows.Forms.ContextMenuStrip IMemu;
        private System.Windows.Forms.ToolStripMenuItem 关闭代理CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProxyList;
    }
}

