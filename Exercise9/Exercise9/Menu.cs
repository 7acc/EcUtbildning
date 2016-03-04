using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise5;
using Exercise8;
using Microsoft.Win32;

namespace Exercise9
{
    class Menu
    {
        Logger newLogger = new Logger();
        EmployeeRegistry testEmployeeRegistry = new EmployeeRegistry();

        Employee employee5 = new Employee("Jacc", "Liden", "9012173077", "100");
        Employee employee1 = new Employee("Jacc", "Liden", "9012173077", "500");
        Employee employee2 = new Employee("Gummi", "Tarzan", "8902014563", "0");
        Employee employee3 = new Employee("Ben", "Dover", "7612059826", "9999");
        Employee employee4 = new Employee("Cpt", "Nemo", "5607186285", "5000");




        private bool menuLoop = true;

        private string menutext = ("[A]dd Employee\n" +
                                   "[R]emove Employee\n" +
                                   "[P]rint Employee list\n" +
                                   "[S]earch employee\n" +
                                   "[V]iew Logg\n" +
                                   "[E]xit\n");
        public void UserMenu()
        {
            testEmployeeRegistry.EmployeeList.Add(employee1);
            testEmployeeRegistry.EmployeeList.Add(employee2);
            testEmployeeRegistry.EmployeeList.Add(employee3);
            testEmployeeRegistry.EmployeeList.Add(employee4);
            testEmployeeRegistry.EmployeeList.Add(employee5);

            while (menuLoop)
            {
                Console.Clear();
                Console.WriteLine(menutext);
                MenuSwitch(Console.ReadKey(true));
            }
        }

        private void MenuSwitch(ConsoleKeyInfo choice)
        {
            switch (choice.Key)
            {
                case ConsoleKey.A:
                    Console.Clear();
                    AddEmployee();
                    break;

                case ConsoleKey.R:
                    Console.Clear();
                    RemoveEmployee();
                    break;

                case ConsoleKey.P:
                    Console.Clear();
                    testEmployeeRegistry.PrintRegistry();
                    Console.ReadKey();
                    break;
                case ConsoleKey.E:
                    menuLoop = false;
                    break;
                case ConsoleKey.S:
                    SearchEmployee();
                    break;
                case ConsoleKey.V:
                    newLogger.PrintLoggs();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                    break;


            }
        }

        private void AddEmployee()
        {
            Console.Write("Enter the firstname of the new Employee: ");
            string newFirstName = Console.ReadLine();
            Console.Write("Enter the lastname of the employee: ");
            string newLastName = Console.ReadLine();
            Console.Write($"whats {newFirstName} {newLastName}´s socialsecurity number?: ");
            string newSocial = CheckValidSSN(Console.ReadLine());
            Console.Write($"How much moneys will {newFirstName} {newLastName} make per hour?:  ");
            string wage = Console.ReadLine();

            testEmployeeRegistry.NewEmployee(newFirstName, newLastName, newSocial, wage);

            newLogger.Logg($"Added {newFirstName} {newLastName}");


        }

        private void RemoveEmployee()
        {

            testEmployeeRegistry.PrintRegistry();

            Console.Write("\nwich employee do you wich to remove?\n" +
                          "Index > ");
            int index;
            var validIndex = int.TryParse(Console.ReadLine(), out index);
            RemoveAtValidIndex(index, validIndex);
        }

        public void RemoveAtValidIndex(int index, bool validIndex)
        {

            if (validIndex && index < testEmployeeRegistry.EmployeeList.Count)
            {

                string removed = testEmployeeRegistry.EmployeeList[index].FullName();
                newLogger.Logg($"Removed {removed}");

                testEmployeeRegistry.RemoveEmployee(index);

                Console.Clear();
                testEmployeeRegistry.PrintRegistry();

                Console.WriteLine(removed + " has been removed");
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("\ninvalid index");
                Console.ReadKey();

            }
        }
        private void SearchEmployee()
        {
            Console.Write("Enter year(YY): ");
            string year = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Employess born {year}\n");

            var list = testEmployeeRegistry.GetEmployeeByYear(year);
            list.ForEach(i => Console.WriteLine(i.GetFullEmployeInfo()));

            if (!list.Any())
            {
                Console.Clear();
                Console.WriteLine($"There is no Employees born {year}");
            }
            Console.ReadKey();
        }

        public static string CheckValidSSN()
        {
            ulong validSSNnr = 0;
            bool loop = true;

            while (loop)
            {
                bool valid = ulong.TryParse(Console.ReadLine(), out validSSNnr);

                if (valid && validSSNnr.ToString().Length == 10)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid socialsecurity number");
                }


            }
            string validSSN = validSSNnr.ToString().Insert(6, "-");
            return validSSN;
        }

        public static string CheckValidSSN(string ssn)
        {
            ulong validSSNnr = 0;
            bool loop = true;
            ssn = ssn.Replace("-", "");
            
            while (loop)
            {
                bool valid = ulong.TryParse(ssn, out validSSNnr);

                if (valid && validSSNnr.ToString().Length == 10)
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Invalid socialsecurity number");
                }


            }
            string validSSN = validSSNnr.ToString().Insert(6, "-");
            return validSSN;
        }
    }
}

