using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Lille", "Björn", "19901105-3277", "95");
            Employee employee2 = new Employee("Mellan", "Björn", "19860123-4167", "105");
            Employee employee3 = new Employee("Pappa", "Björn", "19680914-5513", "175");
            Employee employee4 = new Employee("Mamma", "Björn", "19701201-3987", "175");

            Employee.AddEmployeToList(employee1);
            Employee.AddEmployeToList(employee2);
            Employee.AddEmployeToList(employee3);
            Employee.AddEmployeToList(employee4);

            Employee employee5 = new Employee("00000101-0101");
            Employee employee6 = new Employee("99990909-9999");

            Employee.AddEmployeToList(employee5);
            Employee.AddEmployeToList(employee6);

            foreach (var emplpyee in Employee.listOfEmployees)
            {
                Console.WriteLine(emplpyee.FullName());
            }
            Console.ReadKey();

            foreach (var employee in Employee.listOfEmployees)
            {
                Console.WriteLine(employee.GetFullEmployeInfo());
            }
            Console.ReadKey();


        }
    }
}
