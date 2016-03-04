using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var newGarage = new CarGarage();

            Car car1 = new Car("Volvo V70", "rlf 569");
            Car car2 = new Car("Evo x", "tyl 056");
            Car car3 = new Car("Ford Escort", "prs 105");
            Car car4 = new Car("peel p50", " asg 101");

            newGarage.CarsNotParked.Add(car1);
            newGarage.CarsNotParked.Add(car2);
            newGarage.CarsNotParked.Add(car3);
            newGarage.CarsNotParked.Add(car4);
            newGarage.GarageMenu();
        }
    }
}
