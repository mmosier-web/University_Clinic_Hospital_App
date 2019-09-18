using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Employee
    {
        public string Name;
        public int EmployeeNumber;
        public int Salary;
        public bool GotPaid;

        public Employee(string name, int employeeNumber, int salary)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Salary = salary;
            GotPaid = false;
        }

        public Employee()
        {

        }

        public int PayEmployee()
        {
            return 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} | Employee Number: {EmployeeNumber} | Salary: {Salary} | GotPaid: {GotPaid}");
            Console.WriteLine("___________________________________________________________________________________________________________________");

        }
    }
}
