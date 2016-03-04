using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise12;


namespace Exercise12
{
     class Logger : iLogger 
    {
        public List<string> LogPosts { get;  set; }

        public Logger()
        {
            LogPosts = new List<string>();
        }

        public void Logg(string message)
        {
            LogPosts.Add($"{message.PadRight(15, ' ')}  {DateTime.Now.ToString("G")}");
        }

        public void PrintLoggs()
        {
            foreach (var logg in LogPosts)
            {
                Console.WriteLine(logg);
            }
        }
    }
}
