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
    }
}
