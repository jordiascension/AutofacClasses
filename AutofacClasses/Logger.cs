using System;

namespace AutofacClasses
{
    public class Logger : ILogger
    {
        public bool WriteLog(string ruta)
        {
            Console.WriteLine("I write in a log console");

            return true;
        }
    }
}
