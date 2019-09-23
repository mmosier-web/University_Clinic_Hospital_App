using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Hospital
    {
        static public List<Employee> medicalEmployees = new List<Employee>()
        {
         new Doctor("Mosier", "322123","Doctor", 90000, "Emergency medicine"),
         new Doctor("Harris", "322124","Doctor", 90000, "Family medicine"),
         new Nurse("Betsy", "222123","Nurse", 50000),
         new Nurse("Jane", "222124","Nurse", 50000),
        };

        static public List<Employee> nonMedicalEmployees = new List<Employee>()
        {
         new Receptionist("Billy", "111123","Receptionist", 45000),
         new Receptionist("John", "111124","Receptionist", 45000),
         new Janitor("Earl", "000123","Janitor", 40000),
         new Janitor("Joe", "000124","Janitor", 40000)
        };

        public List<Employee> allHospitalEmployees = medicalEmployees.Concat(nonMedicalEmployees).ToList();


        public void PrintEmployeeList()
        {
            int Id = 1;
            foreach (Employee employee in allHospitalEmployees)
            {
                Console.Write(Id + " ");
                employee.ShowAllInfo();
                Id++;
            }
        }
        
        public void PrintAllMedicalEmployees()
        {
            int Id = 1;
            foreach (Employee employee in medicalEmployees)
            {
                Console.Write(Id + " ");
                employee.ShowInfoForPatientAction();
                Id++;
            }
        }

        public Employee SelectOneEmployee()
        {
            Console.WriteLine("\n\nSelect a Medical Employee: \n");
            Employee selectedEmployee = allHospitalEmployees[Convert.ToInt32(Console.ReadLine()) - 1];
            Console.Clear();
            return selectedEmployee;
        }

        public void DrawPatientsBlood(Employee selectedEmployee, Patient selectedPatient)
        {
            selectedEmployee.DrawBlood (selectedPatient);
        }

        public void CareForPatient(Employee selectedEmployee, Patient selectedPatientToCareFor)
        {
            selectedEmployee.CareForPatient(selectedPatientToCareFor);
        }

        static public List<Patient> rnBetsyPatientList = new List<Patient>()
        {
            new Patient ("Rubi"),
            new Patient ("Luther"),
        };

        static public List<Patient> rnJanePatientList = new List<Patient>()
        {
            new Patient ("Johnny"),
            new Patient ("Makenzie"),
        };

        public List<Patient> allPatientsList = rnBetsyPatientList.Concat(rnJanePatientList).ToList();

        public Patient SelectOnePatient()
        {
            Console.WriteLine("\n\nSelect a Patient: \n");
            Patient selectedPatient = allPatientsList[Convert.ToInt32(Console.ReadLine()) - 1];
            return selectedPatient;
        }

        public void PrintAllPatientsList()
        {
            int Id = 1;
            foreach (Patient patient in rnBetsyPatientList)
            {
                Console.Write(Id + " ");
                patient.ShowPatientInfo();
                Id++;
            }

            foreach (Patient patient in rnJanePatientList)
            {
                Console.Write(Id + " ");
                patient.ShowPatientInfo();
                Id++;
            }
        }

        public void PayAllEmployees()
        {
            foreach (Employee employee in allHospitalEmployees)
            {
                employee.PayEmployee();
            }
        }

    }
}
