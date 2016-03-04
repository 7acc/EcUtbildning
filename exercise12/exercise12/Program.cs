using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise12;

namespace exercise12
{
    class Program 
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var application = new LoggApplication(logger);
            application.Run();
        }
    }
}
