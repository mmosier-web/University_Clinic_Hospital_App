using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Janitor : Employee
    {
        public bool FloorSweeping { get; set; }
        public Janitor (string name, string employeeNumber, int salary) : base(name, employeeNumber, salary)
        {
            FloorSweeping = false;
        }
        public override void ShowInfo()
        {

            if (GotPaid == false && FloorSweeping == false)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has not been paid, Has swept the floor");

            else if (GotPaid == true && FloorSweeping == true)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has been paid, is sweping the floor");

            else if (GotPaid == true && FloorSweeping == false)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has been paid, Has swept the floor");

            else if (GotPaid == false && FloorSweeping == true)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has not been paid, is sweping the floor");
        }
    }
}
