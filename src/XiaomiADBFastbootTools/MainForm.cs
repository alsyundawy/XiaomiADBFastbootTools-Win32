using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiaomiADBFastbootTools
{
    public partial class MainForm : Form
    {
        string imagefile = "";
        string driverfolder = Directory.GetCurrentDirectory() + "\\drivers";
        string output = "";

        public MainForm()
        {
            InitializeComponent();
            partitionBox.SelectedIndex = 0;
            serialLabel.Text = "";
            codenameLabel.Text = "";
            bootloaderLabel.Text = "";
            ((ToolStripDropDownMenu)(loadfastboot.Owner)).ShowCheckMargin = false;
            ((ToolStripDropDownMenu)(loadadb.Owner)).ShowImageMargin = false;
        }

        public bool Fastboot_Check()
        {
            tbOutput.Text = "Please wait...";
            Cursor.Current = Cursors.WaitCursor;
            string str = "";
            if (File.Exists(driverfolder + "\\fastboot.exe") != true) str += "fastboot.exe not found!\r\n";
            if (File.Exists(driverfolder + "\\AdbWinApi.dll") != true) str += "AdbWinApi.dll not found!\r\n";
            if (File.Exists(driverfolder + "\\AdbWinUsbApi.dll") != true) str += "AdbWinUsbApi.dll not found!\r\n";
            tbOutput.Text = str;
            if (str != "")
                return false;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = driverfolder + "\\fastboot.exe";
            process.StartInfo = startInfo;

            startInfo.Arguments = "devices";
            process.Start();
            string line = process.StandardOutput.ReadLine();
            if (line == null)
            {
                tbOutput.Text = "No device found!";
                process.Close();
                return false;
            }

            serialLabel.Text = line.Remove(line.Length-9);
            process.Close();

            startInfo.Arguments = "getvar product";
            process.Start();
            codenameLabel.Text = process.StandardError.ReadLine().Substring(9);
            process.Close();

            startInfo.Arguments = "oem device-info";
            process.Start();
            string info = process.StandardError.ReadToEnd();
            if (info.Contains("unlocked: true")) bootloaderLabel.Text = "unlocked";
            if (info.Contains("unlocked: false")) bootloaderLabel.Text = "locked";
            process.Close();
            return true;
        }

        public bool ADB_Check()
        {
            tbOutput.Text = "Please wait...";
            Cursor.Current = Cursors.WaitCursor;
            string str = "";
            if (File.Exists(driverfolder + "\\adb.exe") != true) str += "adb.exe not found!\r\n";
            if (File.Exists(driverfolder + "\\AdbWinApi.dll") != true) str += "AdbWinApi.dll not found!\r\n";
            if (File.Exists(driverfolder + "\\AdbWinUsbApi.dll") != true) str += "AdbWinUsbApi.dll not found!\r\n";
            tbOutput.Text = str;
            if (str != "")
                return false;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = driverfolder + "\\adb.exe";
            process.StartInfo = startInfo;

            startInfo.Arguments = "get-serialno";
            process.Start();
            string line = process.StandardError.ReadToEnd();
            if (line.Contains("no devices"))
            {
                tbOutput.Text = "No device found!";
                return false;
            }
            if (line.Contains("unauthorized"))
            {
                tbOutput.Text = "Device unauthorised!\r\nPlease allow USB debugging!";
                return false;
            }
            serialLabel.Text = process.StandardOutput.ReadToEnd();
            process.Close();

            startInfo.Arguments = "shell getprop ro.product.name";
            process.Start();
            codenameLabel.Text = process.StandardOutput.ReadToEnd();
            process.Close();

            startInfo.Arguments = "shell getprop ro.boot.flash.locked";
            process.Start();
            string bl = process.StandardOutput.ReadToEnd();
            if (bl.Contains("0")) bootloaderLabel.Text = "unlocked";
            if (bl.Contains("1")) bootloaderLabel.Text = "locked";
            process.Close();
            return true;
        }

        public void Fastboot(string[] args)
        {
            tbOutput.Text = "Please wait...";
            Cursor.Current = Cursors.WaitCursor;
            if (Fastboot_Check() != true) return;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = driverfolder + "\\fastboot.exe";
            process.StartInfo = startInfo;
            tbOutput.Text = "";
            string op;

            foreach (string s in args)
            {
                startInfo.Arguments = s;
                process.Start();
                op = process.StandardError.ReadToEnd();
                if (op.Length > 0)
                    tbOutput.Text += op;
                op = process.StandardOutput.ReadToEnd();
                if (op.Length > 0)
                    tbOutput.Text += op;
                process.Close();
            }
        }

        public void ADB(string[] args)
        {
            tbOutput.Text = "Please wait...";
            Cursor.Current = Cursors.WaitCursor;
            if (ADB_Check() != true) return;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = driverfolder + "\\adb.exe";
            process.StartInfo = startInfo;
            tbOutput.Text = "";
            string op;

            foreach (string s in args)
            {
                startInfo.Arguments = s;
                process.Start();
                op = process.StandardError.ReadToEnd();
                if (op.Length > 0)
                    tbOutput.Text += op;
                op = process.StandardOutput.ReadToEnd();
                if (op.Length > 0)
                    tbOutput.Text += op;
                process.Close();
            }
        }

        public void Uninstall(App app)
        {
            Cursor.Current = Cursors.WaitCursor;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = driverfolder + "\\adb.exe";
            process.StartInfo = startInfo;
            output += (app.AppName + ":\r\n");
            foreach (string s in app.PackageNames)
            {
                startInfo.Arguments = "shell pm uninstall --user 0 " + s;
                process.Start();
                output += ("- " + process.StandardOutput.ReadToEnd());
                process.Close();
            }
        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            imageBrowser.FileName = "";
            if (imageBrowser.ShowDialog() == DialogResult.OK)
            {
                imagefile = imageBrowser.FileName;
            }
            if (partitionBox.SelectedItem.ToString() == "recovery" && imagefile.Length > 0)
                bBootRecovery.Enabled = true;
            if (partitionBox.SelectedItem.ToString() != "recovery" || imagefile.Length == 0)
                bBootRecovery.Enabled = false;
        }

        private void partitionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (partitionBox.SelectedItem.ToString() == "recovery" && imagefile.Length > 0)
                bBootRecovery.Enabled = true;
            if (partitionBox.SelectedItem.ToString() != "recovery" || imagefile.Length == 0)
                bBootRecovery.Enabled = false;
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.ShowDialog();
        }

        private void loaddevice_Click(object sender, EventArgs e)
        {
            Fastboot_Check();
        }

        private void loadadb_Click(object sender, EventArgs e)
        {
            ADB_Check();
        }

        private void browsedrivers_Click(object sender, EventArgs e)
        {
            if (driverBrowser.ShowDialog() == DialogResult.OK)
            {
                driverfolder = driverBrowser.SelectedPath;
            }
            string str = "";
            if (File.Exists(driverfolder + "\\adb.exe") != true) str += "adb.exe not found!\r\n";
            if (File.Exists(driverfolder + "\\fastboot.exe") != true) str += "fastboot.exe not found!\r\n";
            if (File.Exists(driverfolder + "\\AdbWinApi.dll") != true) str += "AdbWinApi.dll not found!\r\n";
            if (File.Exists(driverfolder + "\\AdbWinUsbApi.dll") != true) str += "AdbWinUsbApi.dll not found!\r\n";
            tbOutput.Text = str;
        }

        private void bFlash_Click(object sender, EventArgs e)
        {
            if (imagefile.Length == 0) return;
            Fastboot(new string[] { "flash " + partitionBox.SelectedItem.ToString() + " " + imagefile });
        }

        private void bBootRecovery_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "boot " + imagefile });
        }

        private void bFastbootRebootSystem_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "reboot" });
        }

        private void bFastbootRebootFastboot_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "reboot bootloader" });
        }

        private void bFastbootRebootEDL_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "oem edl" });
        }

        private void bWipeCache_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "erase cache" });
        }

        private void bWipeData_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "erase cache", "erase userdata" });
        }

        private void bUnlock_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "oem unlock" });
        }

        private void bLock_Click(object sender, EventArgs e)
        {
            Fastboot(new string[] { "oem lock" });
        }

        private void bADBRebootSystem_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "Rebooting...";
            ADB(new string[] { "reboot" });
        }

        private void bADBRebootRecovery_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "Rebooting...";
            ADB(new string[] { "reboot recovery" });
        }

        private void bADBRebootFastboot_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "Rebooting...";
            ADB(new string[] { "reboot bootloader" });
        }

        private void bADBRebootEDL_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "Rebooting...";
            ADB(new string[] { "reboot edl" });
        }

        private void bDeviceProperties_Click(object sender, EventArgs e)
        {
            if (ADB_Check() != true) return;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = driverfolder + "\\adb.exe";
            startInfo.Arguments = "shell getprop";
            process.StartInfo = startInfo;
            InfoForm inf = new InfoForm();
            process.Start();
            inf.InfoText = process.StandardOutput.ReadToEnd();
            inf.ShowDialog();
            process.Close();
        }

        private void bDebloater_Click(object sender, EventArgs e)
        {
            if (ADB_Check() != true) return;
            Debloater dlg = new Debloater();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbOutput.Text = "Please wait...";
                foreach (object selected in dlg.appListBox.CheckedItems)
                {
                    foreach (App app in dlg.Apps)
                    {
                        if (app.AppName == selected.ToString())
                            Uninstall(app);
                    }
                }
                foreach (App app in dlg.CustomApps)
                {
                    Uninstall(app);
                }
                tbOutput.Text = output;
                output = "";
            }
        }

        private void bCamera2API_Click(object sender, EventArgs e)
        {
            tbOutput.Text = "Camera2 API enabled!";
            ADB(new string[] { "shell setprop persist.camera.HAL3.enabled 1", "shell setprop persist.camera.eis.enable 1" });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process[] proc1 = System.Diagnostics.Process.GetProcessesByName("adb");
            foreach (System.Diagnostics.Process p in proc1)
                p.Kill();
            System.Diagnostics.Process[] proc2 = System.Diagnostics.Process.GetProcessesByName("fastboot");
            foreach (System.Diagnostics.Process p in proc2)
                p.Kill();
        }
    }
}
