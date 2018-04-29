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
    public partial class Debloater : Form
    {
        public List<App> Apps = new List<App>();
        public List<App> CustomApps = new List<App>();

        public Debloater()
        {
            InitializeComponent();
            FillApps();
        }

        public void FillApps()
        {
            Apps.Add(new App("App Vault", new string[] { "com.mi.android.globalpersonalassistant" }));
            Apps.Add(new App("Apps (Mi App Store)", new string[] { "com.xiaomi.mipicks" }));
            Apps.Add(new App("Browser", new string[] { "com.android.browser" }));
            Apps.Add(new App("Calculator", new string[] { "com.miui.calculator" }));
            Apps.Add(new App("Calendar", new string[] { "com.android.calendar" }));
            Apps.Add(new App("Cleaner", new string[] { "com.miui.cleanmaster" }));
            Apps.Add(new App("Clock", new string[] { "com.android.deskclock" }));
            Apps.Add(new App("Compass", new string[] { "com.miui.compass" }));
            Apps.Add(new App("Downloads", new string[] { "com.android.providers.downloads.ui" }));
            Apps.Add(new App("Facebook (all services)", new string[] { "com.facebook.katana", "com.facebook.system", "com.facebook.appmanager", "com.facebook.services" }));
            Apps.Add(new App("Feedback", new string[] { "com.miui.bugreport" }));
            Apps.Add(new App("File Manager", new string[] { "com.mi.android.globalFileexplorer" }));
            Apps.Add(new App("FM Radio", new string[] { "com.miui.fm" }));
            Apps.Add(new App("Gmail", new string[] { "com.google.android.gm" }));
            Apps.Add(new App("Google App", new string[] { "com.google.android.googlequicksearchbox" }));
            Apps.Add(new App("Google Chrome", new string[] { "com.android.chrome" }));
            Apps.Add(new App("Google Drive", new string[] { "com.google.android.apps.docs" }));
            Apps.Add(new App("Google Duo", new string[] { "com.google.android.apps.tachyon" }));
            Apps.Add(new App("Google Hangouts", new string[] { "com.google.android.talk" }));
            Apps.Add(new App("Google Maps", new string[] { "com.google.android.apps.maps" }));
            Apps.Add(new App("Google Photos", new string[] { "com.google.android.apps.photos" }));
            Apps.Add(new App("Google Play Movies", new string[] { "com.google.android.videos" }));
            Apps.Add(new App("Google Play Music", new string[] { "com.google.android.music" }));
            Apps.Add(new App("Mail", new string[] { "com.android.email" }));
            Apps.Add(new App("Mi Cloud & Backup", new string[] { "com.miui.cloudservice", "com.miui.cloudbackup" }));
            Apps.Add(new App("Mi Credit", new string[] { "com.xiaomi.payment" }));
            Apps.Add(new App("Mi Drop", new string[] { "com.xiaomi.midrop" }));
            Apps.Add(new App("Mi Video", new string[] { "com.miui.videoplayer" }));
            Apps.Add(new App("Mobile Device Information Provider", new string[] { "com.amazon.appmanager" }));
            Apps.Add(new App("Music", new string[] { "com.miui.player" }));
            Apps.Add(new App("Notes", new string[] { "com.miui.notes" }));
            Apps.Add(new App("Quick Apps / Direct Service", new string[] { "com.miui.hybrid" }));
            Apps.Add(new App("Recorder", new string[] { "com.android.soundrecorder" }));
            Apps.Add(new App("Scanner", new string[] { "com.xiaomi.scanner" }));
            Apps.Add(new App("Screen Recorder", new string[] { "com.miui.screenrecorder" }));
            Apps.Add(new App("Weather", new string[] { "com.miui.weather2" }));
            Apps.Add(new App("Xiaomi SIM Activate Service", new string[] { "com.xiaomi.simactivate.service" }));
            Apps.Add(new App("Yellow Pages", new string[] { "com.miui.yellowpage" }));
            Apps.Add(new App("YouTube", new string[] { "com.google.android.youtube" }));
        }

        private void bAddApps_Click(object sender, EventArgs e)
        {
            CustomAppAdder dlg = new CustomAppAdder();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] apps = dlg.tbApps.Text.Trim().Split('\n');
                foreach (string str in apps)
                {
                    if (str.Length > 0)
                    CustomApps.Add(new App(str, new string[] { str }));
                }
            }
        }
    }
}
