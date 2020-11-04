using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }


                /*
                Console.Write("Digite o numero de campos:");
                int x = int.Parse(Console.ReadLine());
                int[,] a = new int[x, x];

                for (int i = 0; i < x; i++)
                {
                    Console.Write("Selecione " + x + " numeros:");
                    string[] values = Console.ReadLine().Split(' ');

                    for (int j = 0; j < x; j++)
                    {
                        a[i, j] = int.Parse(values[j]);
                    }

                }

                Console.WriteLine("Main diagonal: ");
                for (int i = 0; i < x; i++)
                {
                    Console.Write(a[i,i] + " ");
                }
                Console.WriteLine();

                int count = 0;
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        if (a[i, j] < 0)
                        {
                            count++;
                        }
                    }
                }

                Console.WriteLine("Negative number: " + count);
                */

                /*
                Console.Write("How many employees will be registered? ");
                int n = int.Parse(Console.ReadLine());

                List<Employee> list = new List<Employee>();

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Employee #" + i + ":");
                    Console.Write("Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Salary: ");
                    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Employee(id, name, salary));
                    Console.WriteLine();
                }

                Console.Write("Enter the employee id that will have salary increase : ");
                int searchId = int.Parse(Console.ReadLine());

                Employee emp = list.Find(x => x.Id == searchId);
                if (emp != null)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.IncreaseSalary(percentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }

                Console.WriteLine();
                Console.WriteLine("Updated list of employees:");
                foreach (Employee obj in list)
                {
                    Console.WriteLine(obj);
                }
            }
            */
            }
    }
}
