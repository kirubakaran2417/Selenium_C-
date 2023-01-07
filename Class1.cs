using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class LogHelpers
    {
        //Declaration of the file stream and format
        private static string _logfile = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        public static StreamWriter stream = null;
        //create a file that will be used to store the log information
        public static void CreateLogFile()
        {
            //create a directory
            string filepath = "C:\\Users\\k.kirubakaran\\source\\repos\\TestProject1\\TestProject1\\";
            if(Directory.Exists(filepath))
            {
                stream=File.AppendText(filepath+_logfile+".log");
            }
            else
            {
                Directory.CreateDirectory(filepath);
                stream = File.AppendText(filepath + _logfile + ".log");

            }
        }
        //create a method that can write the information into the log file
        public static void WriteToFile(string Message)
        {
            stream.Write("{0}{1}");
        }
    }
}
