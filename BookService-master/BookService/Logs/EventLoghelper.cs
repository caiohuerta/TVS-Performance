using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace IdalenBackendServices.Logs
{
    public class EventLoghelper
    {
        static readonly object _fileAccess = new object();

        public static void WriteBodyLog(string msg)
        {
            lock (_fileAccess) {
                string head = msg;
                var path = System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/LogFile.txt");
                // Write the string to a file.

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(head);
                }
            }
            

        }
       
    }
}