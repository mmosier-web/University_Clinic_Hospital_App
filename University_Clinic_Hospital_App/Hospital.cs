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
         new Doctor("Dr.Mosier", "322123", 90000, "Emergency medicine"),
         new Doctor("Dr.Harris", "322124", 90000, "Family medicine"),
         new Nurse("Rn.Betsy", "222123", 50000),
         new Nurse("Rn.Jane", "222124", 50000),
        };

        static public List<Employee> nonMedicalEmployees = new List<Employee>()
        {
         new Receptionist("Rec-BillyBob", "111123", 45000),
         new Receptionist("Rec-John", "111124", 45000),
         new Janitor("Earl the Janitor", "000123", 40000),
         new Janitor("Joe the Janitor", "000124", 40000)
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
            Console.WriteLine("Select a Doctor: \n");
            Employee selectedEmployee = allHospitalEmployees[Convert.ToInt32(Console.ReadLine()) - 1];
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
            Console.WriteLine("Select a Patient: \n");
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

        public int PayAllEmployees()
        {
            foreach (Employee employee in allHospitalEmployees)
            {
                int GotPaid = employee.GotPaid;

                if (GotPaid == 0)
                { //int GotPaid;
                    return employee.PayEmployee(/*GotPaid*/);
                    //int GotPaid = employee.PayEmployee();
                }
                else if (GotPaid == 1)
                {
                    return 2;
                }
            }
            return 2;
        }

        public void CheckPayStatus()
        {
            foreach(Employee employee in allHospitalEmployees)
            {

            }
        }

    }
}
