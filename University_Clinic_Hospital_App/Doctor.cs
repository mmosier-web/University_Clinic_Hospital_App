using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Doctor : Employee
    {
        public string Specialty;

        public Doctor(string name, string employeeNumber, int salary, string specialty): base ( name, employeeNumber, salary)
        {
            Specialty = specialty;
        }

        public Doctor() : base()
        {

        }
        public override void ShowInfo()
        {

            if (GotPaid == 0) 
            Console.WriteLine($"{ Name}, Employee Number;{EmployeeNumber}, Employee Salary:{Salary},{Specialty}, Has not been paid yet");

            else
                Console.WriteLine($"{ Name}, Employee Number;{EmployeeNumber}, Employee Salary:{Salary},{Specialty}, Has been paid");
        }

        public override void DrawBlood(Patient patient)
        {
            patient.Blood_Level -= 4;
            Console.WriteLine($"{Name} drew blood from {patient.Name} \n\n{patient.Name} blood level is now {patient.Blood_Level}");
            Console.ReadKey();
        }
    }
}
