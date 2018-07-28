namespace XiaomiADBFastbootTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadadb = new System.Windows.Forms.ToolStripMenuItem();
            this.loadfastboot = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceinfoBox = new System.Windows.Forms.GroupBox();
            this.bootloaderLabel = new System.Windows.Forms.Label();
            this.codenameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBrowser = new System.Windows.Forms.OpenFileDialog();
            this.flasherGroup = new System.Windows.Forms.GroupBox();
            this.bBootRecovery = new System.Windows.Forms.Button();
            this.bFlash = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.partitionBox = new System.Windows.Forms.ComboBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bootBox = new System.Windows.Forms.GroupBox();
            this.bFastbootRebootEDL = new System.Windows.Forms.Button();
            this.bFastbootRebootFastboot = new System.Windows.Forms.Button();
            this.bFastbootRebootSystem = new System.Windows.Forms.Button();
            this.wiperGroup = new System.Windows.Forms.GroupBox();
            this.bWipeData = new System.Windows.Forms.Button();
            this.bWipeCache = new System.Windows.Forms.Button();
            this.unlockerGroup = new System.Windows.Forms.GroupBox();
            this.bLock = new System.Windows.Forms.Button();
            this.bUnlock = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.driverBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.adbGroup = new System.Windows.Forms.GroupBox();
            this.bCamera2API = new System.Windows.Forms.Button();
            this.bDebloater = new System.Windows.Forms.Button();
            this.bDeviceProperties = new System.Windows.Forms.Button();
            this.adbRebooterGroup = new System.Windows.Forms.GroupBox();
            this.bADBRebootEDL = new System.Windows.Forms.Button();
            this.bADBRebootRecovery = new System.Windows.Forms.Button();
            this.bADBRebootFastboot = new System.Windows.Forms.Button();
            this.bADBRebootSystem = new System.Windows.Forms.Button();
            this.fastbootGroup = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.deviceinfoBox.SuspendLayout();
            this.flasherGroup.SuspendLayout();
            this.bootBox.SuspendLayout();
            this.wiperGroup.SuspendLayout();
            this.unlockerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.adbGroup.SuspendLayout();
            this.adbRebooterGroup.SuspendLayout();
            this.fastbootGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(897, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsMenu
            // 
            this.optionsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadadb,
            this.loadfastboot,
            this.about});
            this.optionsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsMenu.Name = "optionsMenu";
            this.optionsMenu.Size = new System.Drawing.Size(69, 21);
            this.optionsMenu.Text = "Options";
            // 
            // loadadb
            // 
            this.loadadb.Name = "loadadb";
            this.loadadb.Size = new System.Drawing.Size(222, 22);
            this.loadadb.Text = "Load device (ADB)";
            this.loadadb.Click += new System.EventHandler(this.loadadb_Click);
            // 
            // loadfastboot
            // 
            this.loadfastboot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadfastboot.Name = "loadfastboot";
            this.loadfastboot.Size = new System.Drawing.Size(222, 22);
            this.loadfastboot.Text = "Load device (Fastboot)";
            this.loadfastboot.Click += new System.EventHandler(this.loaddevice_Click);
            // 
            // about
            // 
            this.about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(222, 22);
            this.about.Text = "About";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // deviceinfoBox
            // 
            this.deviceinfoBox.Controls.Add(this.bootloaderLabel);
            this.deviceinfoBox.Controls.Add(this.codenameLabel);
            this.deviceinfoBox.Controls.Add(this.label3);
            this.deviceinfoBox.Controls.Add(this.serialLabel);
            this.deviceinfoBox.Controls.Add(this.label2);
            this.deviceinfoBox.Controls.Add(this.label1);
            this.deviceinfoBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceinfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.deviceinfoBox.Location = new System.Drawing.Point(0, 0);
            this.deviceinfoBox.Name = "deviceinfoBox";
            this.deviceinfoBox.Size = new System.Drawing.Size(348, 81);
            this.deviceinfoBox.TabIndex = 1;
            this.deviceinfoBox.TabStop = false;
            this.deviceinfoBox.Text = "Device Info";
            // 
            // bootloaderLabel
            // 
            this.bootloaderLabel.AutoSize = true;
            this.bootloaderLabel.Location = new System.Drawing.Point(99, 57);
            this.bootloaderLabel.Name = "bootloaderLabel";
            this.bootloaderLabel.Size = new System.Drawing.Size(68, 18);
            this.bootloaderLabel.TabIndex = 5;
            this.bootloaderLabel.Text = "unlocked";
            // 
            // codenameLabel
            // 
            this.codenameLabel.AutoSize = true;
            this.codenameLabel.Location = new System.Drawing.Point(96, 39);
            this.codenameLabel.Name = "codenameLabel";
            this.codenameLabel.Size = new System.Drawing.Size(49, 18);
            this.codenameLabel.TabIndex = 4;
            this.codenameLabel.Text = "kenzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bootloader:";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(116, 21);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(129, 18);
            this.serialLabel.TabIndex = 3;
            this.serialLabel.Text = "345bo3b4ghghg5b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codename:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial number:";
            // 
            // imageBrowser
            // 
            this.imageBrowser.Filter = "Image Files (*.img;*.bin)|*.img;*.bin";
            this.imageBrowser.Title = "Select the image to be flashed";
            // 
            // flasherGroup
            // 
            this.flasherGroup.Controls.Add(this.bBootRecovery);
            this.flasherGroup.Controls.Add(this.bFlash);
            this.flasherGroup.Controls.Add(this.label4);
            this.flasherGroup.Controls.Add(this.partitionBox);
            this.flasherGroup.Controls.Add(this.bBrowse);
            this.flasherGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.flasherGroup.Location = new System.Drawing.Point(3, 19);
            this.flasherGroup.Name = "flasherGroup";
            this.flasherGroup.Size = new System.Drawing.Size(539, 71);
            this.flasherGroup.TabIndex = 2;
            this.flasherGroup.TabStop = false;
            this.flasherGroup.Text = "Image Flasher";
            // 
            // bBootRecovery
            // 
            this.bBootRecovery.Enabled = false;
            this.bBootRecovery.Location = new System.Drawing.Point(360, 36);
            this.bBootRecovery.Name = "bBootRecovery";
            this.bBootRecovery.Size = new System.Drawing.Size(175, 27);
            this.bBootRecovery.TabIndex = 4;
            this.bBootRecovery.Text = "Boot into Recovery";
            this.bBootRecovery.UseVisualStyleBackColor = true;
            this.bBootRecovery.Click += new System.EventHandler(this.bBootRecovery_Click);
            // 
            // bFlash
            // 
            this.bFlash.ForeColor = System.Drawing.Color.Red;
            this.bFlash.Location = new System.Drawing.Point(258, 36);
            this.bFlash.Name = "bFlash";
            this.bFlash.Size = new System.Drawing.Size(96, 27);
            this.bFlash.TabIndex = 3;
            this.bFlash.Text = "Flash!";
            this.bFlash.UseVisualStyleBackColor = true;
            this.bFlash.Click += new System.EventHandler(this.bFlash_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select partition:";
            // 
            // partitionBox
            // 
            this.partitionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partitionBox.FormattingEnabled = true;
            this.partitionBox.Items.AddRange(new object[] {
            "antirbpass",
            "boot",
            "cust",
            "modem",
            "persist",
            "recovery",
            "system"});
            this.partitionBox.Location = new System.Drawing.Point(143, 39);
            this.partitionBox.Name = "partitionBox";
            this.partitionBox.Size = new System.Drawing.Size(109, 24);
            this.partitionBox.TabIndex = 1;
            this.partitionBox.SelectedIndexChanged += new System.EventHandler(this.partitionBox_SelectedIndexChanged);
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(6, 36);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(131, 27);
            this.bBrowse.TabIndex = 0;
            this.bBrowse.Text = "Browse for image";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bootBox
            // 
            this.bootBox.Controls.Add(this.bFastbootRebootEDL);
            this.bootBox.Controls.Add(this.bFastbootRebootFastboot);
            this.bootBox.Controls.Add(this.bFastbootRebootSystem);
            this.bootBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bootBox.Location = new System.Drawing.Point(3, 156);
            this.bootBox.Name = "bootBox";
            this.bootBox.Size = new System.Drawing.Size(539, 61);
            this.bootBox.TabIndex = 3;
            this.bootBox.TabStop = false;
            this.bootBox.Text = "Rebooter";
            // 
            // bFastbootRebootEDL
            // 
            this.bFastbootRebootEDL.Location = new System.Drawing.Point(366, 22);
            this.bFastbootRebootEDL.Name = "bFastbootRebootEDL";
            this.bFastbootRebootEDL.Size = new System.Drawing.Size(169, 27);
            this.bFastbootRebootEDL.TabIndex = 2;
            this.bFastbootRebootEDL.Text = "Reboot into EDL mode";
            this.bFastbootRebootEDL.UseVisualStyleBackColor = true;
            this.bFastbootRebootEDL.Click += new System.EventHandler(this.bFastbootRebootEDL_Click);
            // 
            // bFastbootRebootFastboot
            // 
            this.bFastbootRebootFastboot.Location = new System.Drawing.Point(167, 22);
            this.bFastbootRebootFastboot.Name = "bFastbootRebootFastboot";
            this.bFastbootRebootFastboot.Size = new System.Drawing.Size(196, 27);
            this.bFastbootRebootFastboot.TabIndex = 1;
            this.bFastbootRebootFastboot.Text = "Reboot into Fastboot mode";
            this.bFastbootRebootFastboot.UseVisualStyleBackColor = true;
            this.bFastbootRebootFastboot.Click += new System.EventHandler(this.bFastbootRebootFastboot_Click);
            // 
            // bFastbootRebootSystem
            // 
            this.bFastbootRebootSystem.Location = new System.Drawing.Point(7, 22);
            this.bFastbootRebootSystem.Name = "bFastbootRebootSystem";
            this.bFastbootRebootSystem.Size = new System.Drawing.Size(156, 27);
            this.bFastbootRebootSystem.TabIndex = 0;
            this.bFastbootRebootSystem.Text = "Reboot into System";
            this.bFastbootRebootSystem.UseVisualStyleBackColor = true;
            this.bFastbootRebootSystem.Click += new System.EventHandler(this.bFastbootRebootSystem_Click);
            // 
            // wiperGroup
            // 
            this.wiperGroup.Controls.Add(this.bWipeData);
            this.wiperGroup.Controls.Add(this.bWipeCache);
            this.wiperGroup.Location = new System.Drawing.Point(3, 97);
            this.wiperGroup.Name = "wiperGroup";
            this.wiperGroup.Size = new System.Drawing.Size(298, 57);
            this.wiperGroup.TabIndex = 4;
            this.wiperGroup.TabStop = false;
            this.wiperGroup.Text = "Wiper";
            // 
            // bWipeData
            // 
            this.bWipeData.ForeColor = System.Drawing.Color.Red;
            this.bWipeData.Location = new System.Drawing.Point(110, 22);
            this.bWipeData.Name = "bWipeData";
            this.bWipeData.Size = new System.Drawing.Size(182, 27);
            this.bWipeData.TabIndex = 1;
            this.bWipeData.Text = "Wipe cache and data";
            this.bWipeData.UseVisualStyleBackColor = true;
            this.bWipeData.Click += new System.EventHandler(this.bWipeData_Click);
            // 
            // bWipeCache
            // 
            this.bWipeCache.Location = new System.Drawing.Point(7, 22);
            this.bWipeCache.Name = "bWipeCache";
            this.bWipeCache.Size = new System.Drawing.Size(97, 27);
            this.bWipeCache.TabIndex = 0;
            this.bWipeCache.Text = "Wipe cache";
            this.bWipeCache.UseVisualStyleBackColor = true;
            this.bWipeCache.Click += new System.EventHandler(this.bWipeCache_Click);
            // 
            // unlockerGroup
            // 
            this.unlockerGroup.Controls.Add(this.bLock);
            this.unlockerGroup.Controls.Add(this.bUnlock);
            this.unlockerGroup.Location = new System.Drawing.Point(307, 97);
            this.unlockerGroup.Name = "unlockerGroup";
            this.unlockerGroup.Size = new System.Drawing.Size(236, 57);
            this.unlockerGroup.TabIndex = 5;
            this.unlockerGroup.TabStop = false;
            this.unlockerGroup.Text = "OEM Unlocker / Locker";
            // 
            // bLock
            // 
            this.bLock.ForeColor = System.Drawing.Color.Red;
            this.bLock.Location = new System.Drawing.Point(122, 21);
            this.bLock.Name = "bLock";
            this.bLock.Size = new System.Drawing.Size(109, 27);
            this.bLock.TabIndex = 1;
            this.bLock.Text = "Lock";
            this.bLock.UseVisualStyleBackColor = true;
            this.bLock.Click += new System.EventHandler(this.bLock_Click);
            // 
            // bUnlock
            // 
            this.bUnlock.Location = new System.Drawing.Point(6, 21);
            this.bUnlock.Name = "bUnlock";
            this.bUnlock.Size = new System.Drawing.Size(108, 27);
            this.bUnlock.TabIndex = 0;
            this.bUnlock.Text = "Unlock";
            this.bUnlock.UseVisualStyleBackColor = true;
            this.bUnlock.Click += new System.EventHandler(this.bUnlock_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbOutput.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(0, 99);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(348, 307);
            this.tbOutput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(0, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Status:";
            // 
            // driverBrowser
            // 
            this.driverBrowser.Description = "Select the folder of the ADB/Fastboot drivers";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbOutput);
            this.splitContainer1.Panel1.Controls.Add(this.deviceinfoBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(897, 406);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.adbGroup);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.fastbootGroup);
            this.splitContainer2.Size = new System.Drawing.Size(545, 406);
            this.splitContainer2.SplitterDistance = 182;
            this.splitContainer2.TabIndex = 6;
            // 
            // adbGroup
            // 
            this.adbGroup.Controls.Add(this.bCamera2API);
            this.adbGroup.Controls.Add(this.bDebloater);
            this.adbGroup.Controls.Add(this.bDeviceProperties);
            this.adbGroup.Controls.Add(this.adbRebooterGroup);
            this.adbGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adbGroup.Location = new System.Drawing.Point(0, 0);
            this.adbGroup.Name = "adbGroup";
            this.adbGroup.Size = new System.Drawing.Size(545, 182);
            this.adbGroup.TabIndex = 0;
            this.adbGroup.TabStop = false;
            this.adbGroup.Text = "ADB Tools";
            // 
            // bCamera2API
            // 
            this.bCamera2API.Location = new System.Drawing.Point(276, 21);
            this.bCamera2API.Name = "bCamera2API";
            this.bCamera2API.Size = new System.Drawing.Size(260, 27);
            this.bCamera2API.TabIndex = 4;
            this.bCamera2API.Text = "Enable camera2 API (TWRP only)";
            this.bCamera2API.UseVisualStyleBackColor = true;
            this.bCamera2API.Click += new System.EventHandler(this.bCamera2API_Click);
            // 
            // bDebloater
            // 
            this.bDebloater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDebloater.Location = new System.Drawing.Point(10, 21);
            this.bDebloater.Name = "bDebloater";
            this.bDebloater.Size = new System.Drawing.Size(260, 60);
            this.bDebloater.TabIndex = 3;
            this.bDebloater.Text = "Debloater";
            this.bDebloater.UseVisualStyleBackColor = true;
            this.bDebloater.Click += new System.EventHandler(this.bDebloater_Click);
            // 
            // bDeviceProperties
            // 
            this.bDeviceProperties.Location = new System.Drawing.Point(276, 54);
            this.bDeviceProperties.Name = "bDeviceProperties";
            this.bDeviceProperties.Size = new System.Drawing.Size(260, 27);
            this.bDeviceProperties.TabIndex = 2;
            this.bDeviceProperties.Text = "Get device properties";
            this.bDeviceProperties.UseVisualStyleBackColor = true;
            this.bDeviceProperties.Click += new System.EventHandler(this.bDeviceProperties_Click);
            // 
            // adbRebooterGroup
            // 
            this.adbRebooterGroup.Controls.Add(this.bADBRebootEDL);
            this.adbRebooterGroup.Controls.Add(this.bADBRebootRecovery);
            this.adbRebooterGroup.Controls.Add(this.bADBRebootFastboot);
            this.adbRebooterGroup.Controls.Add(this.bADBRebootSystem);
            this.adbRebooterGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adbRebooterGroup.Location = new System.Drawing.Point(3, 87);
            this.adbRebooterGroup.Name = "adbRebooterGroup";
            this.adbRebooterGroup.Size = new System.Drawing.Size(539, 92);
            this.adbRebooterGroup.TabIndex = 1;
            this.adbRebooterGroup.TabStop = false;
            this.adbRebooterGroup.Text = "Rebooter";
            // 
            // bADBRebootEDL
            // 
            this.bADBRebootEDL.Location = new System.Drawing.Point(273, 56);
            this.bADBRebootEDL.Name = "bADBRebootEDL";
            this.bADBRebootEDL.Size = new System.Drawing.Size(260, 27);
            this.bADBRebootEDL.TabIndex = 3;
            this.bADBRebootEDL.Text = "Reboot into EDL mode";
            this.bADBRebootEDL.UseVisualStyleBackColor = true;
            this.bADBRebootEDL.Click += new System.EventHandler(this.bADBRebootEDL_Click);
            // 
            // bADBRebootRecovery
            // 
            this.bADBRebootRecovery.Location = new System.Drawing.Point(273, 23);
            this.bADBRebootRecovery.Name = "bADBRebootRecovery";
            this.bADBRebootRecovery.Size = new System.Drawing.Size(260, 27);
            this.bADBRebootRecovery.TabIndex = 2;
            this.bADBRebootRecovery.Text = "Reboot into Recovery mode";
            this.bADBRebootRecovery.UseVisualStyleBackColor = true;
            this.bADBRebootRecovery.Click += new System.EventHandler(this.bADBRebootRecovery_Click);
            // 
            // bADBRebootFastboot
            // 
            this.bADBRebootFastboot.Location = new System.Drawing.Point(7, 56);
            this.bADBRebootFastboot.Name = "bADBRebootFastboot";
            this.bADBRebootFastboot.Size = new System.Drawing.Size(260, 27);
            this.bADBRebootFastboot.TabIndex = 1;
            this.bADBRebootFastboot.Text = "Reboot into Fastboot mode";
            this.bADBRebootFastboot.UseVisualStyleBackColor = true;
            this.bADBRebootFastboot.Click += new System.EventHandler(this.bADBRebootFastboot_Click);
            // 
            // bADBRebootSystem
            // 
            this.bADBRebootSystem.Location = new System.Drawing.Point(7, 23);
            this.bADBRebootSystem.Name = "bADBRebootSystem";
            this.bADBRebootSystem.Size = new System.Drawing.Size(260, 27);
            this.bADBRebootSystem.TabIndex = 0;
            this.bADBRebootSystem.Text = "Reboot into System";
            this.bADBRebootSystem.UseVisualStyleBackColor = true;
            this.bADBRebootSystem.Click += new System.EventHandler(this.bADBRebootSystem_Click);
            // 
            // fastbootGroup
            // 
            this.fastbootGroup.Controls.Add(this.unlockerGroup);
            this.fastbootGroup.Controls.Add(this.wiperGroup);
            this.fastbootGroup.Controls.Add(this.bootBox);
            this.fastbootGroup.Controls.Add(this.flasherGroup);
            this.fastbootGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastbootGroup.Location = new System.Drawing.Point(0, 0);
            this.fastbootGroup.Name = "fastbootGroup";
            this.fastbootGroup.Size = new System.Drawing.Size(545, 220);
            this.fastbootGroup.TabIndex = 6;
            this.fastbootGroup.TabStop = false;
            this.fastbootGroup.Text = "Fastboot Tools";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(897, 431);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Xiaomi ADB/Fastboot Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.deviceinfoBox.ResumeLayout(false);
            this.deviceinfoBox.PerformLayout();
            this.flasherGroup.ResumeLayout(false);
            this.flasherGroup.PerformLayout();
            this.bootBox.ResumeLayout(false);
            this.wiperGroup.ResumeLayout(false);
            this.unlockerGroup.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.adbGroup.ResumeLayout(false);
            this.adbRebooterGroup.ResumeLayout(false);
            this.fastbootGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsMenu;
        private System.Windows.Forms.ToolStripMenuItem loadfastboot;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.GroupBox deviceinfoBox;
        private System.Windows.Forms.Label bootloaderLabel;
        private System.Windows.Forms.Label codenameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog imageBrowser;
        private System.Windows.Forms.GroupBox flasherGroup;
        private System.Windows.Forms.Button bBootRecovery;
        private System.Windows.Forms.Button bFlash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox partitionBox;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.GroupBox bootBox;
        private System.Windows.Forms.Button bFastbootRebootEDL;
        private System.Windows.Forms.Button bFastbootRebootFastboot;
        private System.Windows.Forms.Button bFastbootRebootSystem;
        private System.Windows.Forms.GroupBox wiperGroup;
        private System.Windows.Forms.Button bWipeData;
        private System.Windows.Forms.Button bWipeCache;
        private System.Windows.Forms.GroupBox unlockerGroup;
        private System.Windows.Forms.Button bLock;
        private System.Windows.Forms.Button bUnlock;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog driverBrowser;
        private System.Windows.Forms.ToolStripMenuItem loadadb;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox adbGroup;
        private System.Windows.Forms.Button bDeviceProperties;
        private System.Windows.Forms.GroupBox adbRebooterGroup;
        private System.Windows.Forms.Button bADBRebootEDL;
        private System.Windows.Forms.Button bADBRebootRecovery;
        private System.Windows.Forms.Button bADBRebootFastboot;
        private System.Windows.Forms.Button bADBRebootSystem;
        private System.Windows.Forms.GroupBox fastbootGroup;
        private System.Windows.Forms.Button bDebloater;
        private System.Windows.Forms.Button bCamera2API;
    }
}

