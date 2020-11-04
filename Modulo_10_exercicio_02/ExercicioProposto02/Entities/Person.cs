using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto02.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Person()
        {
        }

        public Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double IncomeTax();
       
    }
}
