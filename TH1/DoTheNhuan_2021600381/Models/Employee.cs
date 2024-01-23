using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoTheNhuan_2021600381.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public double Salary { get; set; }
        public int WorkDays { get; set; }

        public double TrueSalary
        {
            get
            {
                if (WorkDays >= 25) return Salary * 1.1;
                else if (WorkDays >= 20) return Salary * 1.05;
                else return Salary;
            }
        }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, string gender, string dOB, double salary, int workDays)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DOB = dOB;
            Salary = salary;
            WorkDays = workDays;
        }



    }
}