using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Countdown
{
    class Logger
    {
        string type;
        List<string> logs = new List<string>();
        public Logger(string c)
        {
            type = c;
        }
        public void Add(string entry)
        {
            logs.Add("[" + type + "] /" + DateTime.Now.ToLongTimeString() + ":" + DateTime.Now.Millisecond.ToString() + "/ " + entry);
        }
        public void AddError(string entry)
        {
            logs.Add("[ERROR] /" + DateTime.Now.ToLongTimeString() + ":" + DateTime.Now.Millisecond.ToString() + "/ " + entry);
        }
        public void ExportLog()
        {
            StreamWriter sw = new StreamWriter(type + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".txt");
            for (int i = 0; i < logs.Count; i++)
            {
                sw.WriteLine(logs[i]);
            }
            sw.Close();
        }
    }
}
