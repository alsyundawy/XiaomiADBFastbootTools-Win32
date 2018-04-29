namespace XiaomiADBFastbootTools
{
    partial class InfoForm
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
            this.bSave = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.textsaverDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(130, 568);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(162, 31);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save as...";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(345, 568);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(162, 31);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.Location = new System.Drawing.Point(12, 12);
            this.tbInfo.Multiline = true;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInfo.Size = new System.Drawing.Size(610, 546);
            this.tbInfo.TabIndex = 0;
            // 
            // textsaverDialog
            // 
            this.textsaverDialog.DefaultExt = "txt";
            this.textsaverDialog.Filter = "Text file (*.txt)|*.txt";
            this.textsaverDialog.Title = "Save the output as a text file";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(635, 611);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.bSave);
            this.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Device information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.SaveFileDialog textsaverDialog;
    }
}