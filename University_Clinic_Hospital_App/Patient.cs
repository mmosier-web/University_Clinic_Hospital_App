using System;
using System.Collections.Generic;
using System.Text;

namespace University_Clinic_Hospital_App
{
    public class Patient
    {
        public string Name;
        public int Blood_Level;
        public int Health_Level;


        public Patient(string name)
        {
            Name = name;
            Blood_Level = 20;
            Health_Level = 10;
        }
        public void ShowPatientInfo()
        {
            Console.WriteLine($"{Name}, Blood Level:{Blood_Level}, Health Level: {Health_Level}");
        }
    }
}
