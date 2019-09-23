using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Receptionist : Employee
    {
        public bool OnThePhone { get; set; }

        public Receptionist (string name, string employeeNumber,string position, int salary) : base(name,employeeNumber, position, salary)
        {
            OnThePhone = false;
        }
        public override void ShowAllInfo()
        {

            if (GotPaid == 0 && OnThePhone == false)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #: {EmployeeNumber} | Salary: ${Salary} | Taking A Call: No | Payroll: Not Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else if (GotPaid == 1 && OnThePhone == true)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #: {EmployeeNumber} | Salary: ${Salary} | Taking A Call: Yes | Payroll: Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else if (GotPaid == 0 && OnThePhone == true)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #: {EmployeeNumber} | Salary: ${Salary} | Taking A Call: Yes | Payroll: Not Paid ");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else if (GotPaid == 1 && OnThePhone == false)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #: {EmployeeNumber} | Salary: ${Salary} | Taking A Call: No | Payroll: Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }
        }
    }
}
