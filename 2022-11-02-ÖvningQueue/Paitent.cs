using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_ÖvningQueue
{
    internal class Patient : Person
    {
        public string Recept { get; set; }
        public string Sickness { get; set; }
        public int TimeIn { get; set; }
        public int TimeOut { get; set; }
        public bool IsVaccinated { get; set; }

        public Patient(string name, string roll, string sickness, int timeIn, int timeOut, bool isVaccinated) : base(name, roll)
        {
            this.Sickness = sickness;
            this.TimeIn = timeIn;
            this.TimeOut = timeOut;  
            this.IsVaccinated = isVaccinated;
        }

        public void PrintValues()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Roll: {0}", this.Roll);
            Console.WriteLine("Sickness: {0}", this.Sickness);
            Console.WriteLine("Time In: {0}", this.TimeIn);
            Console.WriteLine("Time Out: {0}\n", this.TimeOut);
        }
    }
}
