using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiaomiADBFastbootTools
{
    public partial class InfoForm : Form
    {
        public string InfoText
        {
            get { return tbInfo.Text; }
            set {
                tbInfo.Text = value;
                if (tbInfo.TextLength > 0)
                    tbInfo.SelectionStart = tbInfo.TextLength - 1;
                }
        }

        public InfoForm()
        {
            InitializeComponent();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (textsaverDialog.ShowDialog() == DialogResult.OK && textsaverDialog.FileName != "")
            {
                System.IO.File.WriteAllText(@textsaverDialog.FileName, tbInfo.Text);
            }
        }
    }
}
