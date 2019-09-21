using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public abstract class Employee
    {
        public string Name;
        public string EmployeeNumber;
        public int Salary;
        public int GotPaid;

        public Employee(string name, string employeeNumber, int salary)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            GotPaid = 0;
        }

        public Employee()
        {

        }

        public virtual int PayEmployee(/*int GotPaid*/)
        {
            if (GotPaid == 0)
            {
               return GotPaid = 1;
            }
            else
            {
                return GotPaid = 2;
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{ Name}{EmployeeNumber}{Salary}{GotPaid}");
        }
        
        public virtual void  DrawBlood(Patient patient)
        {

        }

    }
}
