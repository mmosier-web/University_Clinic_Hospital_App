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
        public override void ShowAllInfo()
        {
            if (GotPaid == 0) 
            Console.WriteLine($"Doctor: {Name} | Employee #:{EmployeeNumber} | Salary:{Salary} | Specialty: {Specialty} | Payroll: Not Paid");

            else
            Console.WriteLine($"Doctor: {Name} | Employee #:{EmployeeNumber} | Salary:{Salary} | Specialty: {Specialty} | Payroll: Paid");
        }

        public override void ShowInfoForPatientAction()
        {
            Console.WriteLine($"Doctor: {Name} | Employee #: {EmployeeNumber} | Speciality: {Specialty}");
        }

        public override void DrawBlood(Patient patient)
        {
            patient.Blood_Level -= 4;
            Console.WriteLine($"{Name} drew blood from {patient.Name} \n{patient.Name} blood level is now {patient.Blood_Level}");
            Console.ReadKey();
        }

        public override void CareForPatient(Patient patient)
        {
            patient.Blood_Level += 15;
            patient.Health_Level += 15;
            Console.WriteLine($"{Name} Cared for {patient.Name} \n{patient.Name} health level is now {patient.Health_Level} and blood level {patient.Blood_Level}");
            Console.ReadKey();
        }
    }
}
