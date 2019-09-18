using System;

namespace University_Clinic_Hospital_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            Console.WriteLine("University Clinic Hospital");

            Console.WriteLine("\nTo check list of employees: enter \"Q\" ");
            Console.WriteLine("To check salary of each employee: enter \"W\" ");
            Console.WriteLine("To check duties of employee enter: \"E\" ");

            string checkList = Console.ReadLine().ToLower();

            if (checkList == "q")
            {

            }

            Console.ReadKey();
        }

    }
}
