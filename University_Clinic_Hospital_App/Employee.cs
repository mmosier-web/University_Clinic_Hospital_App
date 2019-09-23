using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public abstract class Employee
    {
        public string Name;
        public string EmployeeNumber;
        public string Position;
        public int Salary;
        public int GotPaid;

        public Employee(string name, string employeeNumber, string position, int salary)
        {
            Name = name;
            EmployeeNumber = employeeNumber;
            Position = position;
            Salary = salary;
            GotPaid = 0;
        }

        public Employee()
        {

        }

        public virtual int PayEmployee()
        {
            if (GotPaid == 0)
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine($"\n${Salary} was paid to {Position} {Name}'s Payroll");
               return GotPaid = 1;
            }
            else
            {
                Console.WriteLine("________________________________________________");
                Console.WriteLine($"\n{Position} {Name} has already been paid this Payroll");
                return GotPaid = 2;
            }
        }

        public virtual void ShowAllInfo()
        {

        }

        public virtual void ShowInfoForPatientAction()
        {

        }
        
        public virtual void DrawBlood(Patient patient)
        {

        }

        public virtual void CareForPatient(Patient patient)
        {

        }

    }
}
