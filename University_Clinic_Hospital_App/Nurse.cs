using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Nurse : Employee
    {
        public int NumberOfPatients { get; set; }

        public Nurse(string name, string employeeNumber,string position, int salary) : base(name, employeeNumber, position, salary)
        {
            NumberOfPatients = 2;
        }

        public override void ShowAllInfo()
        {
            if (GotPaid == 0)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #: {EmployeeNumber} | Salary: ${Salary} | # of Patients: {NumberOfPatients} | Payroll: Not Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }
            else
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #: {EmployeeNumber} | Salary: ${Salary} | # of Patients: {NumberOfPatients} | Payroll: Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }
        }

        public override void ShowInfoForPatientAction()
        {
            Console.WriteLine($"{Position} {Name} | Employee #: {EmployeeNumber}");
            Console.WriteLine("______________________________________________________________________");
        }

        public override void DrawBlood(Patient patient)
        {
            Console.Clear();
            patient.Blood_Level = -2;
            Console.WriteLine($"\n\n{Position} {Name} drew blood from {patient.Name} \n\n{patient.Name}'s blood level is now {patient.Blood_Level}");
            Console.ReadKey();
            Console.Clear();
        }

        public override void CareForPatient(Patient patient)
        {
            Console.Clear();
            patient.Blood_Level += 10;
            patient.Health_Level += 10;
            Console.WriteLine($"\n\n{Position} {Name} Cared for {patient.Name} \n\n{patient.Name}'s health level is now {patient.Health_Level} and blood level {patient.Blood_Level}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
