using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Doctor : Employee
    {
        public string Specialty;

        public Doctor(string name, int employeeNumber, int salary, string specialty): base ( name, employeeNumber, salary)
        {
            Specialty = specialty;
        }

        public Doctor() : base()
        {

        }
    }
}
