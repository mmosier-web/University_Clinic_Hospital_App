using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Hospital
    {

        public List<Employee> employeeList = new List<Employee>()
        {

         new Doctor("Dr.Mosier", 322123, 90000, "Emergency medicine"),
         new Doctor("Dr.Harris", 322124, 90000, "Family medicine"),
         new Doctor("Dr.smith", 322125, 90000, "bariatric surgery"),
         new Doctor("Dr.houston", 322126, 90000, "Geriatric medicine"),
         new Nurse("Rn.Betsy", 222123, 50000),
         new Nurse("Rn.Jane", 222124, 50000),
         new Receptionist("Rec-BillyBob", 111123, 45000),
         new Receptionist("Rec-John", 111124, 45000),
         new Janitor("Earl the Janitor", 000123, 40000),
         new Janitor("Joe the Janitor", 000124, 40000)

        };

        public void PrintList()
        {
            foreach (Employee employee in employeeList)
            {
                employee.ShowInfo();
            }
        }
    }
}
