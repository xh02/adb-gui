namespace adbGUI.Forms
{
      partial class MainForm
      {
            /// <summary>
            /// Erforderliche Designervariable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Verwendete Ressourcen bereinigen.
            /// </summary>
            /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
            protected override void Dispose(bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose();
                  }
                  base.Dispose(disposing);
            }

            #region Vom Windows Form-Designer generierter Code

            /// <summary>
            /// Erforderliche Methode für die Designerunterstützung.
            /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("文件");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sideload");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("所有用户");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("最多用户");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("IMEI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("账户");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("备份恢复");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("手机", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("截图");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("录屏");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("分辨率");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("屏幕密度");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("显示", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("获取配置");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("更改配置");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("配置", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("进程");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("内存");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("电池服务状态");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("收集电池数据");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("重置电池数据");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("电池", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("告警管理器状态");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("启动时间");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("CPU信息");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("磁盘数据");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("权限");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("文件系统");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("重新挂载系统分区");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("系统", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("网络流量");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("网络监控");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("WiFi信息");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("查看Hosts文件");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("网络信息");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("MAC伪装");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("网络", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("所有应用");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("系统库");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("系统特性");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("安装和卸载");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("应用", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("当前日志");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("缓存区中的日志");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("储存到文件");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("清除日志缓冲区");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("高级选项");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("详细");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("调试");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("信息");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("警告");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("错误");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("严重");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("静默");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("筛选", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode52,
            treeNode53,
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("日志抓取", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46,
            treeNode47,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("系统服务");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("内核信息");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("日志", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57,
            treeNode58});
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("fastboot设备");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("开机");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("正常重启");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("重启到Bootloader");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("清除");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("清除Recovery分区");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("刷写");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("帮助");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("版本");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Fastboot功能", new System.Windows.Forms.TreeNode[] {
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66,
            treeNode67,
            treeNode68});
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("帮助");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("adb版本信息");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Adb", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("鸣谢");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("关于", new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode73});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_executeCommand = new System.Windows.Forms.Button();
            this.trv_commandTreeView = new System.Windows.Forms.TreeView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbx_customCommand = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consoleStop = new System.Windows.Forms.Button();
            this.btn_ConsoleClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsc_ConnectedDevices = new System.Windows.Forms.ToolStripComboBox();
            this.tsm_PowerRebootNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PowerRebootRecovery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PowerRebootBootloader = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PowerRebootFastboot = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PowerSideloadMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PowerShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_PowerSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.tst_IpAdress = new System.Windows.Forms.ToolStripTextBox();
            this.tsm_WirelessConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_WirelessDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.电源菜单项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无线连接的adbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭adb服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开shellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以root运行adbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adbUnrootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.开源申明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlwaysClearConsole = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_executeCommand
            // 
            this.btn_executeCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_executeCommand.Location = new System.Drawing.Point(782, 572);
            this.btn_executeCommand.Margin = new System.Windows.Forms.Padding(4);
            this.btn_executeCommand.Name = "btn_executeCommand";
            this.btn_executeCommand.Size = new System.Drawing.Size(82, 32);
            this.btn_executeCommand.TabIndex = 1;
            this.btn_executeCommand.Text = "执行";
            this.btn_executeCommand.UseVisualStyleBackColor = true;
            this.btn_executeCommand.Click += new System.EventHandler(this.Btn_executeCommand_Click);
            // 
            // trv_commandTreeView
            // 
            this.trv_commandTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.trv_commandTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trv_commandTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.trv_commandTreeView.Location = new System.Drawing.Point(5, 2);
            this.trv_commandTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.trv_commandTreeView.Name = "trv_commandTreeView";
            treeNode1.Name = "Knoten0";
            treeNode1.Tag = "#FileOps";
            treeNode1.Text = "文件";
            treeNode2.Name = "Knoten2";
            treeNode2.Tag = "#Sideload";
            treeNode2.Text = "Sideload";
            treeNode3.Name = "Knoten15";
            treeNode3.Tag = "adb shell pm list users";
            treeNode3.Text = "所有用户";
            treeNode4.Name = "Knoten17";
            treeNode4.Tag = "adb shell pm get-max-users";
            treeNode4.Text = "最多用户";
            treeNode5.Name = "Knoten19";
            treeNode5.Tag = "adb exec-out \"service call iphonesubinfo 4 | cut -c 52-66 | tr -d \'.[:space:]\'\"";
            treeNode5.Text = "IMEI";
            treeNode6.Name = "Knoten27";
            treeNode6.Tag = "adb shell dumpsys account";
            treeNode6.Text = "账户";
            treeNode7.Name = "Knoten3";
            treeNode7.Tag = "#BackupRestore";
            treeNode7.Text = "备份恢复";
            treeNode8.Name = "Knoten3";
            treeNode8.Tag = "";
            treeNode8.Text = "手机";
            treeNode9.Name = "Knoten31";
            treeNode9.Tag = "%screenshot";
            treeNode9.Text = "截图";
            treeNode9.ToolTipText = "截取屏幕";
            treeNode10.Name = "Knoten0";
            treeNode10.Tag = "#ScreenRecord";
            treeNode10.Text = "录屏";
            treeNode10.ToolTipText = "录屏3分钟（华为设备因缺少二进制文件或许不支持)";
            treeNode11.Name = "Knoten1";
            treeNode11.Tag = "#ResolutionChange";
            treeNode11.Text = "分辨率";
            treeNode11.ToolTipText = "改变屏幕分辨率";
            treeNode12.Name = "Knoten2";
            treeNode12.Tag = "#Density";
            treeNode12.Text = "屏幕密度";
            treeNode13.Name = "Knoten0";
            treeNode13.Tag = "";
            treeNode13.Text = "显示";
            treeNode14.Name = "Knoten4";
            treeNode14.Tag = "adb shell getprop";
            treeNode14.Text = "获取配置";
            treeNode15.Name = "Knoten1";
            treeNode15.Tag = "#SetProp";
            treeNode15.Text = "更改配置";
            treeNode16.Name = "Knoten0";
            treeNode16.Tag = "";
            treeNode16.Text = "配置";
            treeNode17.Name = "Knoten8";
            treeNode17.Tag = "adb shell ps";
            treeNode17.Text = "进程";
            treeNode18.Name = "Knoten9";
            treeNode18.Tag = "adb shell dumpsys meminfo";
            treeNode18.Text = "内存";
            treeNode19.Name = "Knoten1";
            treeNode19.Tag = "adb shell dumpsys battery";
            treeNode19.Text = "电池服务状态";
            treeNode20.Name = "Knoten2";
            treeNode20.Tag = "adb shell dumpsys batterystats";
            treeNode20.Text = "收集电池数据";
            treeNode21.Name = "Knoten3";
            treeNode21.Tag = "adb shell dumpsys batterystats --reset";
            treeNode21.Text = "重置电池数据";
            treeNode22.Name = "Knoten22";
            treeNode22.Tag = "";
            treeNode22.Text = "电池";
            treeNode23.Name = "Knoten12";
            treeNode23.Tag = "adb shell dumpsys alarm";
            treeNode23.Text = "告警管理器状态";
            treeNode24.Name = "Knoten16";
            treeNode24.Tag = "adb shell uptime";
            treeNode24.Text = "启动时间";
            treeNode25.Name = "Knoten24";
            treeNode25.Tag = "adb shell dumpsys cpuinfo";
            treeNode25.Text = "CPU信息";
            treeNode26.Name = "Knoten26";
            treeNode26.Tag = "adb shell dumpsys diskstats";
            treeNode26.Text = "磁盘数据";
            treeNode27.Name = "Knoten28";
            treeNode27.Tag = "adb shell pm list permissions";
            treeNode27.Text = "权限";
            treeNode28.Name = "Knoten0";
            treeNode28.Tag = "adb shell df -h";
            treeNode28.Text = "文件系统";
            treeNode29.Name = "Knoten0";
            treeNode29.Tag = "adb remount";
            treeNode29.Text = "重新挂载系统分区";
            treeNode30.Name = "Knoten0";
            treeNode30.Tag = "";
            treeNode30.Text = "系统";
            treeNode31.Name = "Knoten7";
            treeNode31.Tag = "adb shell iftop";
            treeNode31.Text = "网络流量";
            treeNode32.Name = "Knoten25";
            treeNode32.Tag = "adb shell netstat";
            treeNode32.Text = "网络监控";
            treeNode33.Name = "Knoten23";
            treeNode33.Tag = "adb shell dumpsys wifi";
            treeNode33.Text = "WiFi信息";
            treeNode34.Name = "Knoten29";
            treeNode34.Tag = "adb shell cat /etc/hosts";
            treeNode34.Text = "查看Hosts文件";
            treeNode35.Name = "Knoten0";
            treeNode35.Tag = "adb shell ifconfig";
            treeNode35.Text = "网络信息";
            treeNode36.Name = "Knoten3";
            treeNode36.Tag = "#SpoofMAc";
            treeNode36.Text = "MAC伪装";
            treeNode37.Name = "Knoten1";
            treeNode37.Tag = "";
            treeNode37.Text = "网络";
            treeNode38.Name = "Knoten11";
            treeNode38.Tag = "adb shell pm list packages -f";
            treeNode38.Text = "所有应用";
            treeNode39.Name = "Knoten13";
            treeNode39.Tag = "adb shell pm list libraries";
            treeNode39.Text = "系统库";
            treeNode40.Name = "Knoten10";
            treeNode40.Tag = "adb shell \"pm list features | cut -c9- | sort\\";
            treeNode40.Text = "系统特性";
            treeNode41.Name = "Knoten1";
            treeNode41.Tag = "#InstallUninstall";
            treeNode41.Text = "安装和卸载";
            treeNode42.Name = "Knoten2";
            treeNode42.Tag = "";
            treeNode42.Text = "应用";
            treeNode43.Name = "Knoten1";
            treeNode43.Tag = "adb logcat";
            treeNode43.Text = "当前日志";
            treeNode44.Name = "Knoten6";
            treeNode44.Tag = "adb logcat -d";
            treeNode44.Text = "缓存区中的日志";
            treeNode45.Name = "Knoten0";
            treeNode45.Tag = "adb logcat -d > logcat.txt";
            treeNode45.Text = "储存到文件";
            treeNode46.Name = "Knoten0";
            treeNode46.Tag = "adb logcat -b all -c";
            treeNode46.Text = "清除日志缓冲区";
            treeNode47.Name = "Knoten0";
            treeNode47.Tag = "#LogcatAdvanced";
            treeNode47.Text = "高级选项";
            treeNode48.Name = "Knoten4";
            treeNode48.Tag = "adb logcat *:V";
            treeNode48.Text = "详细";
            treeNode49.Name = "Knoten5";
            treeNode49.Tag = "adb logcat *:D";
            treeNode49.Text = "调试";
            treeNode50.Name = "Knoten6";
            treeNode50.Tag = "adb logcat *:I";
            treeNode50.Text = "信息";
            treeNode51.Name = "Knoten7";
            treeNode51.Tag = "adb logcat *:W";
            treeNode51.Text = "警告";
            treeNode52.Name = "Knoten8";
            treeNode52.Tag = "adb logcat *:E";
            treeNode52.Text = "错误";
            treeNode53.Name = "Knoten9";
            treeNode53.Tag = "adb logcat *:F";
            treeNode53.Text = "严重";
            treeNode54.Name = "Knoten11";
            treeNode54.Tag = "adb logcat *:S";
            treeNode54.Text = "静默";
            treeNode55.Name = "Knoten3";
            treeNode55.Tag = "";
            treeNode55.Text = "筛选";
            treeNode56.Name = "Knoten0";
            treeNode56.Tag = "";
            treeNode56.Text = "日志抓取";
            treeNode57.Name = "Knoten5";
            treeNode57.Tag = "adb shell dumpsys";
            treeNode57.Text = "系统服务";
            treeNode58.Name = "Knoten21";
            treeNode58.Tag = "adb shell dmesg";
            treeNode58.Text = "内核信息";
            treeNode59.Name = "Knoten20";
            treeNode59.Tag = "";
            treeNode59.Text = "日志";
            treeNode60.Name = "Knoten2";
            treeNode60.Tag = "fastboot devices";
            treeNode60.Text = "fastboot设备";
            treeNode61.Name = "Knoten8";
            treeNode61.Tag = "fastboot continue";
            treeNode61.Text = "开机";
            treeNode62.Name = "Knoten4";
            treeNode62.Tag = "fastboot reboot";
            treeNode62.Text = "正常重启";
            treeNode63.Name = "Knoten3";
            treeNode63.Tag = "fastboot reboot bootloader";
            treeNode63.Text = "重启到Bootloader";
            treeNode64.Name = "Knoten5";
            treeNode64.Tag = "#Erase";
            treeNode64.Text = "清除";
            treeNode65.Name = "Knoten6";
            treeNode65.Tag = "fastboot erase recovery";
            treeNode65.Text = "清除Recovery分区";
            treeNode66.Name = "Knoten7";
            treeNode66.Tag = "#Flash";
            treeNode66.Text = "刷写";
            treeNode67.Name = "Knoten1";
            treeNode67.Tag = "fastboot help";
            treeNode67.Text = "帮助";
            treeNode68.Name = "Knoten3";
            treeNode68.Tag = "fastboot --version";
            treeNode68.Text = "版本";
            treeNode69.Name = "Knoten0";
            treeNode69.Tag = "";
            treeNode69.Text = "Fastboot功能";
            treeNode70.Name = "Knoten1";
            treeNode70.Tag = "adb help";
            treeNode70.Text = "帮助";
            treeNode71.Name = "Knoten2";
            treeNode71.Tag = "adb version";
            treeNode71.Text = "adb版本信息";
            treeNode72.Name = "Knoten0";
            treeNode72.Tag = "";
            treeNode72.Text = "Adb";
            treeNode73.Name = "Knoten1";
            treeNode73.Tag = "#Credits";
            treeNode73.Text = "鸣谢";
            treeNode74.Name = "Knoten0";
            treeNode74.Tag = "";
            treeNode74.Text = "关于";
            this.trv_commandTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode13,
            treeNode30,
            treeNode37,
            treeNode42,
            treeNode59,
            treeNode69,
            treeNode74});
            this.trv_commandTreeView.Size = new System.Drawing.Size(289, 540);
            this.trv_commandTreeView.TabIndex = 0;
            this.trv_commandTreeView.DoubleClick += new System.EventHandler(this.Trv_commandTreeView_DoubleClick);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.UseFading = false;
            // 
            // cbx_customCommand
            // 
            this.cbx_customCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_customCommand.AutoCompleteCustomSource.AddRange(new string[] {
            "devices"});
            this.cbx_customCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbx_customCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_customCommand.FormattingEnabled = true;
            this.cbx_customCommand.Location = new System.Drawing.Point(326, 576);
            this.cbx_customCommand.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_customCommand.Name = "cbx_customCommand";
            this.cbx_customCommand.Size = new System.Drawing.Size(447, 32);
            this.cbx_customCommand.TabIndex = 12;
            this.cbx_customCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cbx_customCommand_KeyDown);
            // 
            // rtb_console
            // 
            this.rtb_console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_console.BackColor = System.Drawing.Color.White;
            this.rtb_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_console.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_console.HideSelection = false;
            this.rtb_console.Location = new System.Drawing.Point(0, 0);
            this.rtb_console.Margin = new System.Windows.Forms.Padding(2);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(718, 448);
            this.rtb_console.TabIndex = 11;
            this.rtb_console.Text = "";
            this.rtb_console.Resize += new System.EventHandler(this.Rtb_console_Resize);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtb_console);
            this.panel1.Location = new System.Drawing.Point(326, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 452);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(326, 541);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "自定义命令:";
            // 
            // btn_consoleStop
            // 
            this.btn_consoleStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_consoleStop.Location = new System.Drawing.Point(874, 572);
            this.btn_consoleStop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consoleStop.Name = "btn_consoleStop";
            this.btn_consoleStop.Size = new System.Drawing.Size(82, 32);
            this.btn_consoleStop.TabIndex = 1;
            this.btn_consoleStop.Text = "停止";
            this.btn_consoleStop.UseVisualStyleBackColor = true;
            this.btn_consoleStop.Click += new System.EventHandler(this.Btn_consoleStop_Click);
            // 
            // btn_ConsoleClear
            // 
            this.btn_ConsoleClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ConsoleClear.Location = new System.Drawing.Point(962, 572);
            this.btn_ConsoleClear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConsoleClear.Name = "btn_ConsoleClear";
            this.btn_ConsoleClear.Size = new System.Drawing.Size(82, 32);
            this.btn_ConsoleClear.TabIndex = 14;
            this.btn_ConsoleClear.Text = "清空";
            this.btn_ConsoleClear.UseVisualStyleBackColor = true;
            this.btn_ConsoleClear.Click += new System.EventHandler(this.Btn_ConsoleClear_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.trv_commandTreeView);
            this.panel2.Location = new System.Drawing.Point(20, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 568);
            this.panel2.TabIndex = 15;
            // 
            // tsc_ConnectedDevices
            // 
            this.tsc_ConnectedDevices.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsc_ConnectedDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsc_ConnectedDevices.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tsc_ConnectedDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsc_ConnectedDevices.Name = "tsc_ConnectedDevices";
            this.tsc_ConnectedDevices.Size = new System.Drawing.Size(222, 28);
            this.tsc_ConnectedDevices.SelectedIndexChanged += new System.EventHandler(this.Tsc_ConnectedDevices_SelectedIndexChanged);
            // 
            // tsm_PowerRebootNormal
            // 
            this.tsm_PowerRebootNormal.Name = "tsm_PowerRebootNormal";
            this.tsm_PowerRebootNormal.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerRebootNormal.Text = "重启";
            this.tsm_PowerRebootNormal.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerRebootRecovery
            // 
            this.tsm_PowerRebootRecovery.Name = "tsm_PowerRebootRecovery";
            this.tsm_PowerRebootRecovery.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerRebootRecovery.Text = "重启到Recovery模式";
            this.tsm_PowerRebootRecovery.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerRebootBootloader
            // 
            this.tsm_PowerRebootBootloader.Name = "tsm_PowerRebootBootloader";
            this.tsm_PowerRebootBootloader.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerRebootBootloader.Text = "重启到Bootloader模式";
            this.tsm_PowerRebootBootloader.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerRebootFastboot
            // 
            this.tsm_PowerRebootFastboot.Name = "tsm_PowerRebootFastboot";
            this.tsm_PowerRebootFastboot.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerRebootFastboot.Text = "重启到Fastboot模式";
            this.tsm_PowerRebootFastboot.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerSideloadMode
            // 
            this.tsm_PowerSideloadMode.Name = "tsm_PowerSideloadMode";
            this.tsm_PowerSideloadMode.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerSideloadMode.Text = "进入Sideload模式";
            this.tsm_PowerSideloadMode.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerShutdown
            // 
            this.tsm_PowerShutdown.Name = "tsm_PowerShutdown";
            this.tsm_PowerShutdown.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerShutdown.Text = "关机";
            this.tsm_PowerShutdown.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tsm_PowerSleep
            // 
            this.tsm_PowerSleep.Name = "tsm_PowerSleep";
            this.tsm_PowerSleep.Size = new System.Drawing.Size(295, 34);
            this.tsm_PowerSleep.Text = "睡眠";
            this.tsm_PowerSleep.Click += new System.EventHandler(this.Tsb_Power_Click);
            // 
            // tst_IpAdress
            // 
            this.tst_IpAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tst_IpAdress.Name = "tst_IpAdress";
            this.tst_IpAdress.Size = new System.Drawing.Size(123, 26);
            this.tst_IpAdress.Text = "192.168.0.44:5555";
            // 
            // tsm_WirelessConnect
            // 
            this.tsm_WirelessConnect.Name = "tsm_WirelessConnect";
            this.tsm_WirelessConnect.Size = new System.Drawing.Size(218, 34);
            this.tsm_WirelessConnect.Text = "连接设备";
            this.tsm_WirelessConnect.Click += new System.EventHandler(this.Tsm_WirelessConnect_Click);
            // 
            // tsm_WirelessDisconnect
            // 
            this.tsm_WirelessDisconnect.Name = "tsm_WirelessDisconnect";
            this.tsm_WirelessDisconnect.Size = new System.Drawing.Size(218, 34);
            this.tsm_WirelessDisconnect.Text = "断开所有设备";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 23);
            this.toolStripLabel1.Text = "已连接设备: ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsc_ConnectedDevices,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(18, 14, 16, 4);
            this.toolStrip1.Size = new System.Drawing.Size(1058, 46);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电源菜单项ToolStripMenuItem,
            this.无线连接的adbToolStripMenuItem,
            this.服务ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 32);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 电源菜单项ToolStripMenuItem
            // 
            this.电源菜单项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_PowerRebootNormal,
            this.tsm_PowerRebootRecovery,
            this.tsm_PowerRebootBootloader,
            this.tsm_PowerRebootFastboot,
            this.tsm_PowerSideloadMode,
            this.tsm_PowerShutdown,
            this.tsm_PowerSleep});
            this.电源菜单项ToolStripMenuItem.Name = "电源菜单项ToolStripMenuItem";
            this.电源菜单项ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.电源菜单项ToolStripMenuItem.Text = "电源";
            // 
            // 无线连接的adbToolStripMenuItem
            // 
            this.无线连接的adbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tst_IpAdress,
            this.tsm_WirelessConnect,
            this.tsm_WirelessDisconnect});
            this.无线连接的adbToolStripMenuItem.Name = "无线连接的adbToolStripMenuItem";
            this.无线连接的adbToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.无线连接的adbToolStripMenuItem.Text = "无线连接";
            // 
            // 服务ToolStripMenuItem
            // 
            this.服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭adb服务ToolStripMenuItem,
            this.打开shellToolStripMenuItem,
            this.以root运行adbToolStripMenuItem,
            this.adbUnrootToolStripMenuItem});
            this.服务ToolStripMenuItem.Name = "服务ToolStripMenuItem";
            this.服务ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.服务ToolStripMenuItem.Text = "服务";
            // 
            // 关闭adb服务ToolStripMenuItem
            // 
            this.关闭adb服务ToolStripMenuItem.Name = "关闭adb服务ToolStripMenuItem";
            this.关闭adb服务ToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.关闭adb服务ToolStripMenuItem.Text = "关闭adb服务";
            this.关闭adb服务ToolStripMenuItem.Click += new System.EventHandler(this.关闭adb服务ToolStripMenuItem_Click);
            // 
            // 打开shellToolStripMenuItem
            // 
            this.打开shellToolStripMenuItem.Name = "打开shellToolStripMenuItem";
            this.打开shellToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.打开shellToolStripMenuItem.Text = "打开shell";
            this.打开shellToolStripMenuItem.Click += new System.EventHandler(this.打开shellToolStripMenuItem_Click);
            // 
            // 以root运行adbToolStripMenuItem
            // 
            this.以root运行adbToolStripMenuItem.Name = "以root运行adbToolStripMenuItem";
            this.以root运行adbToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.以root运行adbToolStripMenuItem.Text = "以root运行adb";
            this.以root运行adbToolStripMenuItem.Click += new System.EventHandler(this.rootAdbToolStripMenuItem_Click);
            // 
            // adbUnrootToolStripMenuItem
            // 
            this.adbUnrootToolStripMenuItem.Name = "adbUnrootToolStripMenuItem";
            this.adbUnrootToolStripMenuItem.Size = new System.Drawing.Size(234, 34);
            this.adbUnrootToolStripMenuItem.Text = "撤销adb root ";
            this.adbUnrootToolStripMenuItem.Click += new System.EventHandler(this.adbUnrootToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.开源申明ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(182, 34);
            this.aboutToolStripMenuItem1.Text = "作者信息";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // 开源申明ToolStripMenuItem
            // 
            this.开源申明ToolStripMenuItem.Name = "开源申明ToolStripMenuItem";
            this.开源申明ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.开源申明ToolStripMenuItem.Text = "开源申明";
            this.开源申明ToolStripMenuItem.Click += new System.EventHandler(this.openSourceToolStripMenuItem_Click);
            // 
            // AlwaysClearConsole
            // 
            this.AlwaysClearConsole.AutoSize = true;
            this.AlwaysClearConsole.Location = new System.Drawing.Point(326, 49);
            this.AlwaysClearConsole.Margin = new System.Windows.Forms.Padding(4);
            this.AlwaysClearConsole.Name = "AlwaysClearConsole";
            this.AlwaysClearConsole.Size = new System.Drawing.Size(162, 28);
            this.AlwaysClearConsole.TabIndex = 18;
            this.AlwaysClearConsole.Text = "总是清理控制台";
            this.AlwaysClearConsole.UseVisualStyleBackColor = true;
            this.AlwaysClearConsole.CheckedChanged += new System.EventHandler(this.Tsb_AlwayClearConsole_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1058, 631);
            this.Controls.Add(this.AlwaysClearConsole);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ConsoleClear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_consoleStop);
            this.Controls.Add(this.btn_executeCommand);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbx_customCommand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adb快捷工具箱";
            this.toolTip.SetToolTip(this, "Enter command without adb.");
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.ToolTip toolTip;
            private System.Windows.Forms.Button btn_executeCommand;
            private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TreeView trv_commandTreeView;
        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_consoleStop;
        private System.Windows.Forms.ComboBox cbx_customCommand;
		private System.Windows.Forms.Button btn_ConsoleClear;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ToolStripComboBox tsc_ConnectedDevices;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootNormal;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootRecovery;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootBootloader;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerRebootFastboot;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSideloadMode;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerShutdown;
        private System.Windows.Forms.ToolStripMenuItem tsm_PowerSleep;
        private System.Windows.Forms.ToolStripTextBox tst_IpAdress;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessConnect;
        private System.Windows.Forms.ToolStripMenuItem tsm_WirelessDisconnect;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 电源菜单项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无线连接的adbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭adb服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开shellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 以root运行adbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adbUnrootToolStripMenuItem;
        private System.Windows.Forms.CheckBox AlwaysClearConsole;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 开源申明ToolStripMenuItem;
    }
}

