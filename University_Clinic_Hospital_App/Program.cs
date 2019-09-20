using System;

namespace University_Clinic_Hospital_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            bool menuLoop = true;

            while (menuLoop)
            {
                Console.WriteLine("University Clinic Hospital");

                Console.WriteLine("\nTo check all employees info press: \"1\" ");

                Console.WriteLine("To check all patients and their info press: \"2\"");

                Console.WriteLine("To pay all employees press: \"3\"");

                Console.WriteLine("To exit press: \"0\"");

                int menuChoice = Convert.ToInt32(Console.ReadLine());

                if (menuChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Employee Info:");
                    Console.WriteLine("___________________________________________________________________________________________________________________");
                    hospital.PrintEmployeeList();
                }

                else if (menuChoice == 2)
                {
                    hospital.PrintAllPatientsList();
                }

                else if (menuChoice == 3)
                {
                    Console.Clear();

                    int GotPaid;
                    GotPaid = hospital.PayAllEmployees();

                    if (GotPaid == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Already paied");
                    }
                }

                if (menuChoice == 0)
                {
                    Environment.Exit(0); //Could also do---> menuLoop = false;
                }

            }
        }
    }
}
