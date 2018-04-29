namespace XiaomiADBFastbootTools
{
    partial class CustomAppAdder
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbApps = new System.Windows.Forms.TextBox();
            this.bDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter apps by their package names (one per line):";
            // 
            // tbApps
            // 
            this.tbApps.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApps.Location = new System.Drawing.Point(12, 29);
            this.tbApps.Multiline = true;
            this.tbApps.Name = "tbApps";
            this.tbApps.Size = new System.Drawing.Size(311, 256);
            this.tbApps.TabIndex = 1;
            // 
            // bDone
            // 
            this.bDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bDone.Location = new System.Drawing.Point(12, 291);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(311, 28);
            this.bDone.TabIndex = 2;
            this.bDone.Text = "Done!";
            this.bDone.UseVisualStyleBackColor = true;
            // 
            // CustomAppAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(335, 327);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.tbApps);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomAppAdder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add custom apps";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDone;
        public System.Windows.Forms.TextBox tbApps;
    }
}