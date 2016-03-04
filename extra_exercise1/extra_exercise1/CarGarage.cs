using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra_exercise1
{
    class CarGarage
    {

       
        






        private bool loop = true;
       public List<Car> CarsNotParked = new List<Car>();
        private Car[] Garage = new Car[10];
        private string menu = "[S]can Garage\n" +
                              "[p]ark car\n" +
                              "[R]etreve car\n" +
                              "[V]iew unparked cars\n" +
                              "[E]xit\n";

        
        

        public void PrintAllCars()
        {
            
            if (!CarsNotParked.Any())
                Console.WriteLine("there is no unparked cars");
            else
            {
                CarsNotParked.ForEach(i => Console.WriteLine($"{CarsNotParked.IndexOf(i)} - {i.GetCarInfo()}\n"));
            }
            
        }
        public void ViewGarage()
        {
            for (int i = 0; i < Garage.Length; i++)
            {
                if (Garage[i] == null)
                    Console.WriteLine($"{i} -EMPTY-");
                else
                {
                    Console.WriteLine($"{i} {Garage[i].GetCarInfo()}");
                }
            }
        }

        public void GarageMenu()
        {
            while (loop)
            {
                Console.Clear();
                Console.WriteLine(menu);
                MenuSwitch(Console.ReadKey(true));
            }
        }

        public void MenuSwitch(ConsoleKeyInfo choice)
        {
            switch (choice.Key)
            {
                case ConsoleKey.S:
                    ViewGarage();
                    Console.ReadKey();
                    break;
                case ConsoleKey.P:

                    PrintAllCars();
                    Console.Write("_______________________\n" +
                                  "select car at spot nr: ");

                    var spot = int.Parse(Console.ReadLine());
                    var selectedCar = SelectCar(CarsNotParked, spot);
                    if (selectedCar is Car)
                    {
                        ViewGarage();
                        Console.Write("___________________\n" +
                                           " select parkingspot nr: ");
                        var parkingSpot = int.Parse(Console.ReadLine());
                        parkingSpot = SelectParkingSpot(parkingSpot);

                        if(parkingSpot != -1)
                        ParkCar(selectedCar, parkingSpot);
                    }
                    else
                    {
                        break;
                    }
                    break;
                case ConsoleKey.R:

                    ViewGarage();
                    Console.Write("_______________________" +
                                 "select car at spot nr: ");
                    spot = int.Parse(Console.ReadLine());
                    selectedCar = GetCar(spot);
                    CarsNotParked.Add(selectedCar);
                    break;
                case ConsoleKey.V:
                    PrintAllCars();
                    Console.ReadKey();
                    break;
                case ConsoleKey.E:
                    loop = false;
                    break;
                default:
                    Console.WriteLine("invalid input");
                    Console.ReadKey();
                    return;
            }
        }

        public Car GetCar(int parkingslot)
        {
            var carToMove = Garage[parkingslot];
            if (Garage[parkingslot] != null)
            {
                carToMove = Garage[parkingslot];
                Garage[parkingslot] = null;
            }

            return carToMove;
        }
   
        public void ParkCar(Car carToPark, int parkingSlot)
        {
            if (Garage[parkingSlot] == null)
            {
                Garage[parkingSlot] = carToPark;
                Console.WriteLine($"your {carToPark.Model} has ben parked");
                Console.ReadKey();
                CarsNotParked.Remove(carToPark);
               
            }

            else
            {
                Console.WriteLine("That spot is occupied!");
                Console.ReadKey();
            }
        }
        public Car SelectCar(List<Car> list, int spot)

        {
            if (spot <= list.Count)
                return list[spot];

            else
                return null;
        }
        public int SelectParkingSpot(int spotToParkOn)
        {
            if (spotToParkOn < Garage.Length)
            {
                if (Garage[spotToParkOn] == null)
                {
                    return spotToParkOn;
                }
                else
                {
                    return -1;
                }
            }
            else           
                return -1;
            
        }
    }
}
