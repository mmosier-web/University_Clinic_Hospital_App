using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Janitor : Employee
    {
        public bool FloorSweeping { get; set; }
        public Janitor (string name, string employeeNumber,string position, int salary) : base(name, employeeNumber, position, salary)
        {
            FloorSweeping = false;
        }
        public override void ShowAllInfo()
        {

            if (GotPaid == 0 && FloorSweeping == false)
            {
                Console.WriteLine($"Position: {Position} | Name: { Name } | Employee #: {EmployeeNumber} | Salary: ${Salary} | Sweeping The Floor: No | Payroll: Not Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else if (GotPaid == 1 && FloorSweeping == true)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name } | Employee #: {EmployeeNumber} | Salary: ${Salary} | Sweeping The Floor: Yes | Payroll: Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else if (GotPaid == 1 && FloorSweeping == false)
            {
                Console.WriteLine($"Position: {Position} | Name: { Name } | Employee #: {EmployeeNumber} | Salary: ${Salary} | Sweeping The Floor: No | Payroll: Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else if (GotPaid == 0 && FloorSweeping == true)
            {
                Console.WriteLine($"Position: {Position} | Name: { Name } | Employee #: {EmployeeNumber} | Salary: ${Salary} | Sweeping The Floor: Yes | Payroll: Not Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }
        }
    }
}
