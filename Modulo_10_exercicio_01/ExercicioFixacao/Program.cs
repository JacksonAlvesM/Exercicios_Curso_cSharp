using ExercicioFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)?");
                string s = Console.ReadLine();
                if (s == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customs));
                }else if (s == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }else if (s == "u")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));   
                }

            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product sla in list)
            {
               
                    Console.WriteLine(sla.PriceTag());
                

            }
        }
    }
}
