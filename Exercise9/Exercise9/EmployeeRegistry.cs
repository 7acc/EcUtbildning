using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise5;

namespace Exercise9
{
    class EmployeeRegistry
    {
       public List<Employee> EmployeeList { get; set; }

        public EmployeeRegistry()
        {
            EmployeeList = new List<Employee>();
        }
       
        public  void NewEmployee(string name, string lastName, string socialSecurityNumber, string hourWage)
        {         
            var newEmployee = new Employee(name, lastName, socialSecurityNumber, hourWage);
            EmployeeList.Add(newEmployee);
        }

        public  void RemoveEmployee(int index)
        {
            EmployeeList.RemoveAt(index);
        }

        public void PrintRegistry()
        {
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                Console.WriteLine($"[{i}]{EmployeeList[i].GetFullEmployeInfo()}");
            }            
        }

        public List<Employee> GetEmployeeByYear(string year)
        {
            return EmployeeList.Where(e => e.SocialSecurityNumber.Substring(0, 2) == year).ToList();
        }

        
    }
}
