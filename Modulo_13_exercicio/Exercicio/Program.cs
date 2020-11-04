using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mercadoria> sla = new List<Mercadoria>();
            string path = @"C:\Users\jackj\Desktop\C#\modulo 13\myfouder\file2.csv";

            try
            {
                using (var reader = new StreamReader(@"C:\Users\jackj\Desktop\C#\modulo 13\myfouder\file1.csv"))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(',');
                        string nome = dados[0];
                        double preco = Convert.ToDouble(dados[1]);
                        double quantidade = Convert.ToDouble(dados[2]);

                        sla.Add(new Mercadoria(nome, preco, quantidade));

                    }


                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            foreach (Mercadoria line in sla)
                            {

                                sw.WriteLine(line.Nome + " " + line.Total());
                            }

                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("an error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
