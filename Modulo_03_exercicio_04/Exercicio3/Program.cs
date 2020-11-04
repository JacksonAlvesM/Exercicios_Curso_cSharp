using System;

namespace Modulo03_Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 3
            /*
            Console.WriteLine("Digite um codigo: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo != 4)
            {
                if (codigo == 1 )
                {
                    Console.WriteLine("Alcool: 1");
                    break;
                }
                else if (codigo == 2)
                {
                    Console.WriteLine("Gasolina: 2");
                    break;
                }
                else if (codigo == 3)
                {
                    Console.WriteLine("Diesiel: 3");
                    break;
                }
                else 
                {
                    Console.WriteLine("Codigo invalido!! digite outro codigo:");
                    codigo = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine("MUITO OBRIGADO");
            */

            //Exercicio 2
            /*
            Console.WriteLine("Digite cordenada de x e y:");
            string[] vet = Console.ReadLine().Split();
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Pertence ao quadrante Q1");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Pertence ao quadrante Q2");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Pertence ao quadrante Q3");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Pertence ao quadrante Q4");
                }
                else
                {
                    Console.WriteLine("Pertence a Origem");
                }
                Console.WriteLine("Digite cordenada de x e y:");
                vet = Console.ReadLine().Split();
            }
            Console.WriteLine(" ");
            */

            //Exercicio 1
            /*
            Console.Write("Digite sua senha: ");
            double senha = double.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha invalida:");
                Console.Write("Digite outra senha:");
                senha = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido!");
            */
        }
    }
}
