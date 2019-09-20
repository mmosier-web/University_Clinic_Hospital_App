using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse (string name, string employeeNumber, int salary) : base(name, employeeNumber, salary)
        {
            NumberOfPatients = 2;
        }
        public override void ShowInfo()
        {

            if (GotPaid == 0)
                Console.WriteLine($"{ Name} Employee Number: {EmployeeNumber} Employee Salary:{Salary}, number of patients:{NumberOfPatients}, Has been paid");

            else
                Console.WriteLine($"{ Name} Employee Number: {EmployeeNumber} Employee Salary:{Salary}, number of patients:{NumberOfPatients}, Has not been paid");
        }
    }
}
