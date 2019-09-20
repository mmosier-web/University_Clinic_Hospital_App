using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Doctor : Employee
    {
        public string Specialty;

        public Doctor(string name, string employeeNumber, int salary, string specialty): base ( name, employeeNumber, salary)
        {
            Specialty = specialty;
        }

        public Doctor() : base()
        {

        }
        public override void ShowInfo()
        {

            if (GotPaid == false) 
            Console.WriteLine($"{ Name}, Employee Number;{EmployeeNumber}, Employee Salary:{Salary},{Specialty}, Has not been paid yet");

            else
                Console.WriteLine($"{ Name}, Employee Number;{EmployeeNumber}, Employee Salary:{Salary},{Specialty}, Has been paid");
        }
    }
}
