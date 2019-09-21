using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Hospital
    {
        public List<Employee> employeeList = new List<Employee>()
        {
         new Doctor("Dr.Mosier", "322123", 90000, "Emergency medicine"),
         new Doctor("Dr.Harris", "322124", 90000, "Family medicine"),
         new Nurse("Rn.Betsy", "222123", 50000),
         new Nurse("Rn.Jane", "222124", 50000),
         new Receptionist("Rec-BillyBob", "111123", 45000),
         new Receptionist("Rec-John", "111124", 45000),
         new Janitor("Earl the Janitor", "000123", 40000),
         new Janitor("Joe the Janitor", "000124", 40000)

        };

        public void PrintEmployeeList()
        {
            foreach (Employee employee in employeeList)
            {
                employee.ShowInfo();
            }
        }

        public List<Patient> rnBetsyPatientList = new List<Patient>()
        {
            new Patient ("Rubi"),
            new Patient ("Luther"),
        };

        public List<Patient> rnJanePatientList = new List<Patient>()
        {
            new Patient ("Johnny"),
            new Patient ("Makenzie"),
        };



        public void PrintAllPatientsList()
        {
            foreach (Patient patient in rnBetsyPatientList)
            {
                patient.ShowPatientInfo();
            }

            foreach (Patient patient in rnJanePatientList)
            {
                patient.ShowPatientInfo();
            }
        }

        public int PayAllEmployees()
        {
            foreach (Employee employee in employeeList)
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
            foreach(Employee employee in employeeList)
            {

            }
        }

    }
}
