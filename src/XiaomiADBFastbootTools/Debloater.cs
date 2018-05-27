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
        public string region;

        public Debloater(string reg)
        {
            region = reg;
            InitializeComponent();
            FillApps();
        }

        public void FillApps()
        {
            if (region.Length > 1)
            {
                if (region.Contains("CN"))
                {
                    Apps.Add(new App("Analytics", "com.miui.analytics"));
                    Apps.Add(new App("App Vault", "com.miui.personalassistant"));
                    Apps.Add(new App("Browser", "com.android.browser"));
                    Apps.Add(new App("Calendar", "com.android.calendar"));
                    Apps.Add(new App("Clock", "com.android.deskclock"));
                    Apps.Add(new App("Downloads", "com.android.providers.downloads.ui"));
                    Apps.Add(new App("Feedback", "com.miui.bugreport"));
                    Apps.Add(new App("File Manager", "com.android.fileexplorer"));
                    Apps.Add(new App("FM Radio", "com.miui.fm"));
                    Apps.Add(new App("Mi AI", "com.miui.voiceassist"));
                    Apps.Add(new App("Mi Cloud", "com.miui.cloudservice", "Mi Cloud & Backup"));
                    Apps.Add(new App("Mi Cloud Backup", "com.miui.cloudbackup", "Mi Cloud & Backup"));
                    Apps.Add(new App("Mi Credit", "com.xiaomi.payment"));
                    Apps.Add(new App("Mi Video", "com.miui.video"));
                    Apps.Add(new App("Mi Wallet", "com.mipay.wallet"));
                    Apps.Add(new App("Music", "com.miui.player"));
                    Apps.Add(new App("Quick Apps", "com.miui.hybrid"));
                    Apps.Add(new App("Recorder", "com.android.soundrecorder"));
                    Apps.Add(new App("Search", "com.android.quicksearchbox"));
                    Apps.Add(new App("Xiaomi Account", "com.xiaomi.vipaccount"));
                    Apps.Add(new App("Xiaomi SIM Activate Service", "com.xiaomi.simactivate.service"));
                    Apps.Add(new App("Yellow Pages", "com.miui.yellowpage"));
                } else {
                    Apps.Add(new App("Analytics", "com.miui.analytics"));
                    Apps.Add(new App("App Vault", "com.mi.android.globalpersonalassistant"));
                    Apps.Add(new App("Apps (Mi App Store)", "com.xiaomi.mipicks"));
                    Apps.Add(new App("Browser", "com.android.browser"));
                    Apps.Add(new App("Calculator", "com.miui.calculator"));
                    Apps.Add(new App("Calendar", "com.android.calendar"));
                    Apps.Add(new App("Cleaner", "com.miui.cleanmaster"));
                    Apps.Add(new App("Clock", "com.android.deskclock"));
                    Apps.Add(new App("Compass", "com.miui.compass"));
                    Apps.Add(new App("Downloads", "com.android.providers.downloads.ui"));
                    Apps.Add(new App("Facebook", "com.facebook.katana", "Facebook (all services)"));
                    Apps.Add(new App("Facebook App Installer", "com.facebook.system", "Facebook (all services)"));
                    Apps.Add(new App("Facebook App Manager", "com.facebook.appmanager", "Facebook (all services)"));
                    Apps.Add(new App("Facebook Services", "com.facebook.services", "Facebook (all services)"));
                    Apps.Add(new App("Feedback", "com.miui.bugreport"));
                    Apps.Add(new App("File Manager", "com.mi.android.globalFileexplorer"));
                    Apps.Add(new App("FM Radio", "com.miui.fm"));
                    Apps.Add(new App("Gmail", "com.google.android.gm"));
                    Apps.Add(new App("Google App", "com.google.android.googlequicksearchbox"));
                    Apps.Add(new App("Google Assistant", "com.google.android.apps.googleassistant"));
                    Apps.Add(new App("Google Chrome", "com.android.chrome"));
                    Apps.Add(new App("Google Drive", "com.google.android.apps.docs"));
                    Apps.Add(new App("Google Duo", "com.google.android.apps.tachyon"));
                    Apps.Add(new App("Google Hangouts", "com.google.android.talk"));
                    Apps.Add(new App("Google Maps", "com.google.android.apps.maps"));
                    Apps.Add(new App("Google Photos", "com.google.android.apps.photos"));
                    Apps.Add(new App("Google Play Movies", "com.google.android.videos"));
                    Apps.Add(new App("Google Play Music", "com.google.android.music"));
                    Apps.Add(new App("Mail", "com.android.email"));
                    Apps.Add(new App("Mi Cloud", "com.miui.cloudservice", "Mi Cloud & Backup"));
                    Apps.Add(new App("Mi Cloud Backup", "com.miui.cloudbackup", "Mi Cloud & Backup"));
                    Apps.Add(new App("Mi Credit", "com.xiaomi.payment"));
                    Apps.Add(new App("Mi Drop", "com.xiaomi.midrop"));
                    Apps.Add(new App("Mi Roaming", "com.miui.virtualsim"));
                    Apps.Add(new App("Mi Video", "com.miui.videoplayer"));
                    Apps.Add(new App("Mobile Device Information Provider", "com.amazon.appmanager"));
                    Apps.Add(new App("Music", "com.miui.player"));
                    Apps.Add(new App("Notes", "com.miui.notes"));
                    Apps.Add(new App("Quick Apps", "com.miui.hybrid"));
                    Apps.Add(new App("Recorder", "com.android.soundrecorder"));
                    Apps.Add(new App("Scanner", "com.xiaomi.scanner"));
                    Apps.Add(new App("Screen Recorder", "com.miui.screenrecorder"));
                    Apps.Add(new App("Weather", "com.miui.weather2"));
                    Apps.Add(new App("Xiaomi SIM Activate Service", "com.xiaomi.simactivate.service"));
                    Apps.Add(new App("Yellow Pages", "com.miui.yellowpage"));
                    Apps.Add(new App("YouTube", "com.google.android.youtube"));
                }

            } else {
                Apps.Add(new App("Calculator", "com.google.android.calculator"));
                Apps.Add(new App("Calendar", "com.google.android.calendar"));
                Apps.Add(new App("Clock", "com.google.android.deskclock"));
                Apps.Add(new App("Feedback", "com.miui.bugreport"));
                Apps.Add(new App("Files", "com.android.documentsui"));
                Apps.Add(new App("Gmail", "com.google.android.gm"));
                Apps.Add(new App("Google App", "com.google.android.googlequicksearchbox"));
                Apps.Add(new App("Google Assistant", "com.google.android.apps.googleassistant"));
                Apps.Add(new App("Google Chrome", "com.android.chrome"));
                Apps.Add(new App("Google Drive", "com.google.android.apps.docs"));
                Apps.Add(new App("Google Duo", "com.google.android.apps.tachyon"));
                Apps.Add(new App("Google Indic Keyboard", "com.google.android.apps.inputmethod.hindi"));
                Apps.Add(new App("Google Korean Input", "com.google.android.inputmethod.korean"));
                Apps.Add(new App("Google Maps", "com.google.android.apps.maps"));
                Apps.Add(new App("Google Pinyin Input", "com.google.android.inputmethod.pinyin"));
                Apps.Add(new App("Google Play Books", "com.google.android.apps.books"));
                Apps.Add(new App("Google Play Games", "com.google.android.play.games"));
                Apps.Add(new App("Google Play Movies", "com.google.android.videos"));
                Apps.Add(new App("Google Play Music", "com.google.android.music"));
                Apps.Add(new App("Google Zhuyin Input", "com.google.android.apps.inputmethod.zhuyin"));
                Apps.Add(new App("PAI", "android.autoinstalls.config.Xiaomi.tissot"));
                Apps.Add(new App("YouTube", "com.google.android.youtube"));
            }
            appListBox.Items.Clear();
            foreach (App a in Apps)
                if (!appListBox.Items.Contains(a.UIName))
                    appListBox.Items.Add(a.UIName);
        }


        private void bAddApps_Click(object sender, EventArgs e)
        {
            CustomAppAdder dlg = new CustomAppAdder();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] apps = dlg.tbApps.Text.Trim().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string str in apps)
                    if (str.Length > 0)
                        Apps.Add(new App(str, str, "Custom"));
            }
        }
    }      
       
   
}
