using System;

namespace University_Clinic_Hospital_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            string checkList;

            Console.WriteLine("University Clinic Hospital");

            Console.WriteLine("\nTo check all employees info press: \"Q\" ");

            Console.WriteLine("To check all patients and their info press: \"W\"");

            Console.WriteLine("To pay all employees press: \"P\"");

            checkList = Console.ReadLine().ToLower();

            Console.Clear();

            if (checkList == "q")
            {
                hospital.PrintEmployeeList();
            }
            else if (checkList == "w")
            {
                hospital.PrintAllPatientsList();
            }
            else if (checkList == "p")
            {
                hospital.PayAllEmployees();
            }

        }
    }
}
