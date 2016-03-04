using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise12
{
    class LoggApplication
    {

        private iLogger logger;
        public LoggApplication(iLogger logger)
        {
            this.logger = logger;
        }

        public void Run()
        {
            do
            {
                Console.Write("[A]dd message to logg\n" +
                              "[P]rint Log\n");

            var choice = Console.ReadKey(true);

            
                switch (choice.Key)
                {
                    case ConsoleKey.A:

                        Console.WriteLine("log: ");
                        string message = Console.ReadLine();

                        logger.Logg(message);
                        break;

                    case ConsoleKey.P:
                        logger.PrintLoggs();
                        break;

                    default:
                        break;


            } 
            } while (true);
                             
        }
    }
}
