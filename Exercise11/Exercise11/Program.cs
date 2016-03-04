using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise10;
namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData data = new VehicleData();

            car volvo = new car();
            Boat Nouticat = new Boat();

            volvo.StartEngine();
            Nouticat.SetSail();

            data.PrintVehicle(volvo);
            data.PrintVehicle(Nouticat);

            Console.ReadKey(true);

        }
    }
}
