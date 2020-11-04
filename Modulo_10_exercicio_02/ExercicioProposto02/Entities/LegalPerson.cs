using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto02.Entities
{
    class LegalPerson : Person
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson()
        {
        }

        public LegalPerson(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double IncomeTax()
        {
            double imposto;
            if (NumberOfEmployees > 10)
            {
               imposto =  AnualIncome * 1.4;
            }
            else
            {
                imposto = AnualIncome * 1.6;
            }
            return imposto;
        }


    }
}
