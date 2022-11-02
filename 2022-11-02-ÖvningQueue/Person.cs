using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_11_02_ÖvningQueue
{
    internal class Person
    {
        public string Name { get; set; }
        public string Roll { get; set; }

        public Person(string name, string roll)
        {
            this.Name = name;
            this.Roll = roll;
        }
    }
}
