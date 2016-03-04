using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise9;

namespace exercise5
{
    class Employee
    {


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

        public string LastName
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
            socialSecutiryNr = Menu.CheckValidSSN(ssn);
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
            if (FirstName != "Unknown" && LastName != "Unknown")
            {
                string fullName = string.Format("{0} {1}", FirstName, LastName);
                return fullName;
            }
            else
            {
                return "The name of this Employe is Unknown";
            }
        }


        public string GetFullEmployeInfo()
        {
            string fullInfo = string.Format(" " +
                                            "Name: {0}" +
                                            "\nSocial Security Number: {1}" +                                         
                                            "\nWage {2} SEK/h" +
                                            "\n----------------------------------\n"
                                            , FullName(), SocialSecurityNumber, hourWage);

            return fullInfo;
        }


    }
}
