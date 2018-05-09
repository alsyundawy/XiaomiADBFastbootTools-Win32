using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XiaomiADBFastbootTools
{
    public class App
    {
        public string AppName;
        public string PackageName;
        public string UIName;

        public App(string a, string b)
        {
            AppName = a;
            PackageName = b;
            UIName = a;
        }

        public App(string a, string b, string c)
        {
            AppName = a;
            PackageName = b;
            UIName = c;
        }
    }
}
