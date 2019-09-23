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

        public override void ShowAllInfo()
        {
            if (GotPaid == 0)
                Console.WriteLine($"Name: {Name} | Employee #: {EmployeeNumber} | Salary: {Salary} | # of Patients: {NumberOfPatients} | Payroll: Not Paid");

            else
                Console.WriteLine($"Name: {Name} | Employee #: {EmployeeNumber} | Salary: {Salary} | # of Patients: {NumberOfPatients} | Payroll: Paid");
        }

        public override void ShowInfoForPatientAction()
        {
            Console.WriteLine($"Nurse: {Name} | Employee #: {EmployeeNumber}");
        }

        public override void DrawBlood(Patient patient)
        {
            patient.Blood_Level = -2;
            Console.WriteLine($"{Name} drew blood from {patient.Name} \n{patient.Name} blood level is now {patient.Blood_Level}");
            Console.ReadKey();
        }

        public override void CareForPatient(Patient patient)
        {
            patient.Health_Level += 10;
            Console.WriteLine($"{Name} Cared for {patient.Name} \n{patient.Name} health level is now {patient.Health_Level} and blood level {patient.Blood_Level}");
            Console.ReadKey();
        }
    }
}
