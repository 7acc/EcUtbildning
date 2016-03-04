using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            DatetimeCalculator Jacc = new DatetimeCalculator();
           
            string born = Console.ReadLine();
            born = born.Replace("-", "");

            var year1 = int.Parse(born.Substring(0,4));
            var month1 = int.Parse(born.Substring(4,2));
            var day1 = int.Parse(born.Substring(6,2));

          
            Jacc.born = new DateTime(year1,month1,day1);

            Console.WriteLine(Jacc.GetDateTimeInfo(Jacc));          
            Console.ReadKey();
            
        }
    }
}
