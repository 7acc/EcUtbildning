using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise1
{
    class Car
    {
        public string RegNumber { get; set; }
        public string Model { get; set; }
        public int Gear { get; set; }
        public bool EngineState { get; set; }

        public Car(string carModel, string regNumber)
        {
            Model = carModel;
           RegNumber = regNumber;
        }

        public void StartEngine()
        {
            if (!EngineState)
            {
                Gear = 1;
                EngineState = true;
                Console.WriteLine("Engine started, it goes - WROOOOM!");
            }
            else
            {
                Console.WriteLine("The engine is already on, fool!");
            }
        }

        public void StopEngine()
        {
            if (EngineState)
            {
                EngineState = false;
                Console.WriteLine("The engine turns off");
            }
            else
            {
                Console.WriteLine("The engine is already off, -_-");
            }
        }

        public void ChangeGear(int gear)
        {
            if (Gear == gear+1 || Gear == gear -1 && gear < 6 && gear > 0)
            {
                Gear = gear;
                Console.WriteLine("Gear changed to ", gear);
            }
            else
            {
                Console.WriteLine("this car has a möpöd engine mate, you cant jump gears like that!");
            }
        }

        public void StoreCar (string model, string regnumber)
        {
            RegNumber = RegNumber;
            Model = model;
        }

        public string GetCarInfo()
        {

            return $"{Model} [{RegNumber}]";
        }
    }
}
