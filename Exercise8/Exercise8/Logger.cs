using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Logger
    {
        public List<string> LogPosts { get; private set; }

        public Logger()
        {
            LogPosts = new List<string>();
        }

        public void Logg(string message)
        {
            LogPosts.Add($"{message.PadRight(15,' ')}  {DateTime.Now.ToString("G")}");
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
