using System;

namespace University_Clinic_Hospital_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            Console.WriteLine("University Clinic Hospital");

            Console.WriteLine("\nTo check all employees info press: \"Q\" ");

            string checkList = Console.ReadLine().ToLower();

            if (checkList == "q")
            {
                hospital.PrintList();
            }

            Console.ReadKey();
        }

    }
}
