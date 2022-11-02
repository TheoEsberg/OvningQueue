using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_ÖvningQueue
{
    internal class Doctor : Person
    {
        public int Salary { get; set; }
        public int WorkTime { get; set; }

        public Doctor(string name, string roll, int salary, int workTime) : base(name, roll)
        {
            this.Salary = salary;
            this.WorkTime = workTime;
        }

        public void PrintValues() {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Roll: {0}", this.Roll);
            Console.WriteLine("Salary: {0}kr", this.Salary);
            Console.WriteLine("Work Time: {0}h\n", this.WorkTime);
        }
    }
}
