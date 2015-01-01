using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace knockknock.readify.net
{
    public class FileLogger
    {
        public static void Log(string functionName, string arguments, string result)
        {
            string fileName = HttpContext.Current.Request.PhysicalApplicationPath + "\\RedPillLog.txt";

            using (System.IO.TextWriter file = new System.IO.StreamWriter(fileName,true))
            {
                file.WriteLine("IP Address: " + HttpContext.Current.Request.UserHostAddress + "\n");
                file.WriteLine("Function Name: " + functionName + "\n");
                file.WriteLine("Arguments: " + arguments + "\n");
                file.WriteLine("Result: " + result + "\n");
                file.WriteLine("\n");
            }
        }
    }
}