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
        public string[] PackageNames;

        public App(string a, string[] b)
        {
            AppName = a;
            PackageNames = b;
        }
    }
}
