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
                    Console.WriteLine("\t\tUniversity Clinic Hospital");

                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Employee Window:");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("\n\t\tList of Employees: | Press - 1 | ");
                    Console.WriteLine("\n\t\tPay Employees:     | Press - 2 |");

                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("Patient Window:");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("\n\t\tPatient Info:      | Press - 3 |");
                    Console.WriteLine("\n\t\tDraw  Blood:       | Press - 4 |");
                    Console.WriteLine("\n\t\tCare For Patients: | Press - 5 |");
                    Console.WriteLine("\n| Exit: Press - 0 |");

                int menuChoice; /*= Convert.ToInt32(Console.ReadLine());*/

                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    if (menuChoice == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nEmployee Info:");
                        Console.WriteLine("___________________________________________________________________________________________________________________");
                        hospital.PrintEmployeeList();
                        Console.WriteLine("\n\nPress any key to go back to 'Main Menu'");
                        Console.ReadKey();
                        Console.Clear();

                    }

                    else if (menuChoice == 2)
                    {
                        Console.Clear();
                        int GotPaid;
                        GotPaid = hospital.PayAllEmployees();
                        hospital.PrintEmployeeList();
                        Console.WriteLine("\nYour Employees have been Paid  \n\nPress any key to go back to 'Main Menu'");
                        Console.ReadKey();
                        Console.Clear();


                        if (GotPaid == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("You have already paid your employees. \n\nPress any key to go back to 'Main Menu'");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                    else if (menuChoice == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("\nPatient Info Info:");
                        Console.WriteLine("____________________________________________________");
                        hospital.PrintAllPatientsList();
                        Console.WriteLine("\n\nPress any key to go back to 'Main Menu'");
                        Console.ReadKey();
                        Console.Clear();
                    }

                    else if (menuChoice == 4)
                    {
                        Console.Clear();
                        hospital.PrintAllMedicalEmployees();
                        Employee selectedEmployee = hospital.SelectOneEmployee();
                        hospital.PrintAllPatientsList();
                        Patient selectedPatient = hospital.SelectOnePatient();
                        hospital.DrawPatientsBlood(selectedEmployee, selectedPatient);
                    }

                    else if (menuChoice == 5)
                    {
                        Console.Clear();
                        hospital.PrintAllMedicalEmployees();
                        Employee selectedEmployee = hospital.SelectOneEmployee();
                        hospital.PrintAllPatientsList();
                        Patient selectedPatientToCareFor = hospital.SelectOnePatient();
                        hospital.CareForPatient(selectedEmployee, selectedPatientToCareFor);
                    }


                    else if (menuChoice == 0)
                    {
                        Environment.Exit(0); //Could also do---> menuLoop = false;
                    }

                    else if (menuChoice != 1)
                    {
                        Console.WriteLine("\nNot a valid menu choise  \nPlese enter a valid menu choice");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nNot a valid menu choise  \nPlese enter a valid menu choice");
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
