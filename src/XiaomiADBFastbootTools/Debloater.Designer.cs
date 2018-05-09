namespace XiaomiADBFastbootTools
{
    partial class Debloater
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
            this.appListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bUninstall = new System.Windows.Forms.Button();
            this.bAddApps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // appListBox
            // 
            this.appListBox.CheckOnClick = true;
            this.appListBox.FormattingEnabled = true;
            this.appListBox.Items.AddRange(new object[] {
            "App Vault",
            "Apps (Mi App Store)",
            "Browser",
            "Calculator",
            "Calendar",
            "Cleaner",
            "Clock",
            "Compass",
            "Downloads",
            "Facebook (all services)",
            "Feedback",
            "File Manager",
            "FM Radio",
            "Gmail",
            "Google App",
            "Google Chrome",
            "Google Drive",
            "Google Duo",
            "Google Hangouts",
            "Google Maps",
            "Google Photos",
            "Google Play Movies",
            "Google Play Music",
            "Mail",
            "Mi Cloud & Backup",
            "Mi Credit",
            "Mi Drop",
            "Mi Video",
            "Mobile Device Information Provider",
            "Music",
            "Notes",
            "Quick Apps / Direct Service",
            "Recorder",
            "Scanner",
            "Screen Recorder",
            "Weather",
            "Xiaomi SIM Activate Service",
            "Yellow Pages",
            "YouTube"});
            this.appListBox.Location = new System.Drawing.Point(12, 29);
            this.appListBox.Name = "appListBox";
            this.appListBox.Size = new System.Drawing.Size(327, 382);
            this.appListBox.Sorted = true;
            this.appListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the apps and services you wish to get rid of:";
            // 
            // bUninstall
            // 
            this.bUninstall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bUninstall.ForeColor = System.Drawing.Color.Red;
            this.bUninstall.Location = new System.Drawing.Point(12, 451);
            this.bUninstall.Name = "bUninstall";
            this.bUninstall.Size = new System.Drawing.Size(327, 28);
            this.bUninstall.TabIndex = 2;
            this.bUninstall.Text = "Uninstall!";
            this.bUninstall.UseVisualStyleBackColor = true;
            // 
            // bAddApps
            // 
            this.bAddApps.ForeColor = System.Drawing.Color.Black;
            this.bAddApps.Location = new System.Drawing.Point(12, 417);
            this.bAddApps.Name = "bAddApps";
            this.bAddApps.Size = new System.Drawing.Size(327, 28);
            this.bAddApps.TabIndex = 3;
            this.bAddApps.Text = "Add custom apps";
            this.bAddApps.UseVisualStyleBackColor = true;
            this.bAddApps.Click += new System.EventHandler(this.bAddApps_Click);
            // 
            // Debloater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(351, 487);
            this.Controls.Add(this.bAddApps);
            this.Controls.Add(this.bUninstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Debloater";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Debloater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bUninstall;
        public System.Windows.Forms.CheckedListBox appListBox;
        private System.Windows.Forms.Button bAddApps;
    }
}