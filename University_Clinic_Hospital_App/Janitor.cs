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
        public override void ShowAllInfo()
        {

            if (GotPaid == 0 && FloorSweeping == false)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has not been paid, Has swept the floor");

            else if (GotPaid == 1 && FloorSweeping == true)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has been paid, is sweping the floor");

            else if (GotPaid == 1 && FloorSweeping == false)
                Console.WriteLine($"{ Name }, Employee Number: {EmployeeNumber}, Employee Salary: {Salary}, Has been paid, Has swept the floor");

            else if (GotPaid == 0 && FloorSweeping == true)
                Console.WriteLine($"Name: { Name } | Employee #: {EmployeeNumber} | Salary: {Salary} | Has not been paid, is sweping the floor");
        }
    }
}
