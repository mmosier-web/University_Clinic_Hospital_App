using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Janitor : Employee
    {
        public bool FloorSweeping { get; set; }
        public Janitor (string name, int employeeNumber, int salary) : base(name, employeeNumber, salary)
        {
            FloorSweeping = true;
        }
        public override void ShowInfo()
        {

            if (GotPaid == false)
            Console.WriteLine($"{ Name } {EmployeeNumber} {Salary} Has not been paid ");
            else
                Console.WriteLine($"{ Name } {EmployeeNumber} {Salary} Has been paid");

            if (FloorSweeping == true)
                Console.WriteLine($"{ Name } {EmployeeNumber} {Salary} Has swept the floor");
            else
                Console.WriteLine($"{ Name } {EmployeeNumber} {Salary} Has not swept the floor");



        }
    }
}
