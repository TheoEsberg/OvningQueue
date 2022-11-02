using System;
using System.Collections;
using System.Collections.Generic;

namespace _2022_11_02_ÖvningQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Patient> CoronaVaccineQueue = new Queue<Patient>();

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
                new Patient("Shrek", "Patient", "Hosta", 20220712, 20221102, false),
                new Patient("Tobbe", "Patient", "Corona", 20221101, 20221105, false),
                new Patient("Fiona", "Patient", "Feber", 20221102, 20221113, true),
                new Patient("Erik", "Patient", "Brutet", 20221102, 20221124, true),
                new Patient("Ronja", "Patient", "Corona", 20221101, 20221112, false)
            };

            // Print values of all doctors
            foreach (Doctor doctor in doctors)
            {
                doctor.PrintValues();
            }

            // Print values of all nurses
            foreach (Nurse nurse in nurses)
            {
                nurse.PrintValues();
            }

            // Print values of all patients
            foreach (Patient patient in patients)
            {
                patient.PrintValues();

                if (!patient.IsVaccinated) {
                    // Add to queue
                    CoronaVaccineQueue.Enqueue(patient);
                }
            }

            // Nurse take bloodsample from patients
            nurses[0].TakeBloodSample(patients[1]);
            nurses[2].TakeBloodSample(patients[0]);
            nurses[1].TakeBloodSample(patients[2]);

            Console.WriteLine();
            doctors[0].WriteRecipe(patients[1]);
            Console.WriteLine(patients[1].Name + " " + patients[1].Recept);
            Console.WriteLine();

            // Write the queue
            foreach (Patient patient in CoronaVaccineQueue) {
                Console.WriteLine("{0} är inte vaccinerad", patient.Name);
            }
            Console.WriteLine();

            // Vaccinate all in the queue
            foreach (Patient patient in patients) {
                if (!patient.IsVaccinated) {
                    patient.IsVaccinated = true;
                    CoronaVaccineQueue.Dequeue();
                    Console.WriteLine("{0} har blivit vaccinerad!", patient.Name);
                }
            }

            if (CoronaVaccineQueue.Count == 0) {
                Console.WriteLine("\nAlla patienter har blivit vaccinerade!");
            }
        }
    }
}
