@CLS
@SET PATH=C:\Windows\Microsoft.NET\Framework\v2.0.50727;%PATH%;
csc  /target:winexe /out:WhatEver.exe /win32icon:Pi.ico WhatEver.cs WhatEver.Designer.cs Proxies.cs JSON.cs Shell32.cs
timeout 10
@REM  /debug+ 