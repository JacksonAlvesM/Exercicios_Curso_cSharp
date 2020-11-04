using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto02.Entities
{
    class PhysicalPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson()
        {
        }

        public PhysicalPerson(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double IncomeTax()
        {
            double imposto;

            if (AnualIncome < 2000.00)
            {
                if (HealthExpenditures <= 0)
                {
                    imposto = AnualIncome * 1.5;
                }
                else
                {
                    imposto = AnualIncome * 1.5 - HealthExpenditures *5.0;
                }
                
            }
            else 
            {
                if (HealthExpenditures <= 0)
                {
                    imposto = AnualIncome * 2.5;
                }
                else
                {
                    imposto = AnualIncome * 2.5 - HealthExpenditures * 5.0;
                }
                
            }
            return imposto;
            
    
            
        }
    }
}
