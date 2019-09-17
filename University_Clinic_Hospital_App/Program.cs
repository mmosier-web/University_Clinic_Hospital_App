using System;

namespace University_Clinic_Hospital_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Dr.Mosier", 322123, 90000, "Gynocologist");
            Doctor doctor2 = new Doctor("Dr.Harris", 322124, 90000, "Cardiologist");
            Nurse nurse1 = new Nurse("Rn.Betsy", 222123, 50000);
            Nurse nurse2 = new Nurse("Rn.MaryJane", 222124, 50000);
            Receptionist receptionist1 = new Receptionist("Rec-BillyBob", 111123, 45000);
            Receptionist receptionist2 = new Receptionist("Rec-John", 111124, 45000);
            Janitor janitor1 = new Janitor("Earl the Janitor", 000123, 40000);
            Janitor janitor2 = new Janitor("Joe the Janitor", 000124, 40000);
        }

    }
}
