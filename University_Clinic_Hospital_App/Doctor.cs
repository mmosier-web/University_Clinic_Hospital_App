using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Doctor : Employee
    {
        public string Specialty;

        public Doctor(string name, string employeeNumber, string position, int salary, string specialty): base ( name, employeeNumber, position, salary)
        {
            Specialty = specialty;
        }

        public Doctor() : base()
        {

        }
        public override void ShowAllInfo()
        {
            if (GotPaid == 0)
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #:{EmployeeNumber} | Salary: ${Salary} | Specialty: {Specialty} | Payroll: Not Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }

            else
            {
                Console.WriteLine($"Position: {Position} | Name: {Name} | Employee #:{EmployeeNumber} | Salary: ${Salary} | Specialty: {Specialty} | Payroll: Paid");
                Console.WriteLine("________________________________________________________________________________________________________________________");
            }
        }

        public override void ShowInfoForPatientAction()
        {
            Console.WriteLine($"{Position} {Name} | Employee #: {EmployeeNumber} | Speciality: {Specialty}");
            Console.WriteLine("______________________________________________________________________");

        }

        public override void DrawBlood(Patient patient)
        {
            Console.Clear();
            patient.Blood_Level -= 4;
            Console.WriteLine($"\n\n{Position} {Name} drew blood from {patient.Name} \n\n{patient.Name}'s blood level is now {patient.Blood_Level}");
            Console.ReadKey();
            Console.Clear();
        }

        public override void CareForPatient(Patient patient)
        {
            Console.Clear();
            patient.Blood_Level += 15;
            patient.Health_Level += 15;
            Console.WriteLine($"\n\n{Position} {Name} Cared for {patient.Name} \n\n{patient.Name}'s health level is now {patient.Health_Level} and blood level {patient.Blood_Level}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
