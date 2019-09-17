using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse (string name, int employeeNumber, int salary) : base(name, employeeNumber, salary)
        {
            NumberOfPatients = 2;

        }
    }
}
