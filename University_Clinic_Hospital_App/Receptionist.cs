using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Receptionist : Employee
    {
        public bool OnThePhone { get; set; }

        public Receptionist (string name, string employeeNumber, int salary) : base(name,employeeNumber, salary)
        {
            OnThePhone = false;
        }
        public override void ShowInfo()
        {
  
           if (GotPaid == 0 && OnThePhone ==false)
                Console.WriteLine($"{ Name}, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has not been paid, is not on the phone");

           else if(GotPaid == 1 && OnThePhone == true)
                Console.WriteLine($"{ Name}, Employee Number: {EmployeeNumber}, Employee Salary: {Salary} ,Has been paid, is on the phone");

           else if(GotPaid == 0 && OnThePhone == true)
                Console.WriteLine($"{ Name}, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has not been paid, is on the phone");

           else if (GotPaid == 1 && OnThePhone == false)
                Console.WriteLine($"{ Name}, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has been paid, is not on the phone");

        }
    }
}
