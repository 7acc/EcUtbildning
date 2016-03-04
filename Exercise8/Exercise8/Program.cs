using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger myLogger = new Logger();
            myLogger.Logg("first");
            myLogger.Logg("second");
            myLogger.Logg("third");

            foreach (var logg in myLogger.LogPosts)
            {
                Console.WriteLine(logg);
            }



            myLogger.PrintLoggs();

            Console.ReadKey();

        }
    }
}
