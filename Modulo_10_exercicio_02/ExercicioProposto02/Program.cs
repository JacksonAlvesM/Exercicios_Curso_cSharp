using ExercicioProposto02.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioProposto02
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                string type = Console.ReadLine();
                if (type == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(name, income, expenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new LegalPerson(name, income, number));
                }


            }

            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (Person tp in list)
            {
                double tax = tp.IncomeTax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine(" TOTAL TAXES: $ " + sum.ToString(" F2 ", CultureInfo.InvariantCulture));

        }
    }
}
