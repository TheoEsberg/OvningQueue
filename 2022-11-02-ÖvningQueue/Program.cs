using System;

namespace _2022_11_02_ÖvningQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor[] doctors =
            {
                new Doctor("Anas", "Doctor", 40000, 160),
                new Doctor("Hudson", "Doctor", 20000, 40)
            };

            Nurse[] nurses =
            {
                new Nurse("Anna", "Nurse", 50000, 140),
                new Nurse("Hanna", "Nurse", 32000, 40),
                new Nurse("Sanna", "Nurse", 30000, 80),
                new Nurse("Ann", "Nurse", 28000, 30)
            };

            Patient[] patients =
            {
                new Patient("Shrek", "Patient", "Hosta", 20220712, 20221102),
                new Patient("Tobbe", "Patient", "Corona", 20221101, 20221105),
                new Patient("Fiona", "Patient", "Feber", 20221102, 20221113),
                new Patient("Erik", "Patient", "Brutet", 20221102, 20221124),
                new Patient("Ronja", "Patient", "Corona", 20221101, 20221112)
            };

            foreach (Doctor doctor in doctors)
            {
                doctor.PrintValues();
            }

            foreach (Nurse nurse in nurses)
            {
                nurse.PrintValues();
            }

            foreach (Patient patient in patients)
            {
                patient.PrintValues();
            }

            nurses[0].TakeBloodSample(patients[1]);

        }
    }
}
