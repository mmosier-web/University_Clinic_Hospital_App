using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Employee
    {
        public string Name;
        public string EmployeeNumber;
        public int Salary;
        public bool GotPaid;

        public Employee(string name, string employeeNumber, int salary)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            GotPaid = false;
        }

        public Employee()
        {

        }

        public virtual bool PayEmployee()
        {
            return GotPaid = true;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{ Name}{EmployeeNumber}{Salary}{GotPaid}");
        }
    }
}
