using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Receptionist : Employee
    {
        public bool OnThePhone { get; set; }

        public Receptionist (string name, int employeeNumber, int salary) : base(name,employeeNumber, salary)
        {
            OnThePhone = false;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{ Name} {EmployeeNumber} {Salary} {GotPaid} {OnThePhone}");
            
        }
    }
}
