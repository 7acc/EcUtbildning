﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise5
{
    class Employee
    {
        public static List<Employee> listOfEmployees = new List<Employee>();

        private string firstName;
        private string lastName;
        private string socialSecutiryNr;
        private string hourWage;

        public string HourWage
        {
            get { return hourWage; }
            set { hourWage = value; }
        }


        public string SocialSecurityNumber
        {
            get { return socialSecutiryNr; }
            set { socialSecutiryNr = value; }
        }


        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public Employee(string firstName, string lastName, string ssn, string hourlyWage)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            socialSecutiryNr = ssn;
            hourWage = hourlyWage;
        }

        public Employee(string ssn)
        {
            socialSecutiryNr = ssn;
            firstName = "Unknown";
            lastName = "Uknown";
            hourWage = "Unknown";


        }

        public string FullName()
        {
            if (FirstName != "Unknown" && Lastname != "Unknown")
            {
                string fullName = string.Format("{0} {1}", FirstName, Lastname);
                return fullName;
            }
            else
            {
                return "The name of this Employe is Unknown";
            }
        }

        public static void AddEmployeToList(Employee employeeToAdd)
        {
            listOfEmployees.Add(employeeToAdd);
        }

        public string GetFullEmployeInfo()
        {
            string fullInfo = string.Format("\nName: {0}" +
                                            "\nSocial Security Number: {1}" +
                                            "\nWage {2} SEK/h"
                                            , FullName(), SocialSecurityNumber,hourWage);

            return fullInfo;
        }


    }
}
