using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRC
{
    class OpenAppCommand : ICommand
    {
        public OpenAppCommand()
        {

        }

        public string Args { get; set; }
        public void Run()
        {
            if (Args?.Length == 2)
            {
                var appName = Args;
                var appPath = getAppPath(appName);
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = appPath;

                using (Process proc = Process.Start(psi))
                {
                    return;
                }
                throw new CommandException("Unable to Run: " + appName);
            }
            throw new CommandException("Invalid Command Argument");

        }

        private string getAppPath(string appName)
        {
            var path =  ConfigurationManager.AppSettings[appName];
            return path;
        }
    }
}
