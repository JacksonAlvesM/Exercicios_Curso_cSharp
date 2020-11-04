using System;
using System.Globalization;

namespace Modulo03_Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio 1
            /*
            int num1 = 0;
            int num2 = 0;

            int resultado = num1 + num2;

            Console.WriteLine(resultado);
            */


            //Exercicio 2
            /*
            double pi = Math.PI;

            double calculoDoRaio = Math.Pow(2.00, 2.0);

            double resultado = calculoDoRaio * pi;

            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
            */

            //Exercicio 3
            /*
            int A, B, C, D;

            A = 5;
            B = 6;
            C = 7;
            D = 8;

            int diferença = A * B - C * D;

            Console.WriteLine(diferença);
            */

            //Exercicio 4
            /*
             int numero = 25;
             double salarioPorHora = 100;
             double horasTrabahadas = 5.50;
             double total = salarioPorHora * horasTrabahadas;




             Console.WriteLine($"Numero: {numero}");
             Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
            */

            //Exercicio 5
            /*
            Console.WriteLine("Selecione codigo, numero de peças e valor do primeiro produto:");

            string[] produto1 = Console.ReadLine().Split();
            int codigo1 = int.Parse(produto1[0]);
            int numeroDePecas1 = int.Parse(produto1[1]);
            double valor1 = double.Parse(produto1[2].ToString(CultureInfo.InvariantCulture));

            Console.WriteLine("Selecione codigo, numero de peças e valor do segundo produto:");

            string[] produto2 = Console.ReadLine().Split();
            int codigo2 = int.Parse(produto2[0]);
            int numeroDePecas2 = int.Parse(produto2[1]);
            double valor2 = double.Parse(produto2[2].ToString(CultureInfo.InvariantCulture));

            double valorASerPago = numeroDePecas1 * valor1 + numeroDePecas2 * valor2;

            Console.WriteLine("Valor a ser pago é: " + valorASerPago.ToString("F2", CultureInfo.InvariantCulture));
            */

            //Exercicio 6 

            float A, B, C;

            A = 3.0F;
            B = 4.0F;
            C = 5.2f;
            double pi = Math.PI;
            double raioC = Math.Pow(C, 2.0);

            float triangulo = (A*C) / 2;

            double areaC = pi * raioC;

            double areaTrapezio = (A + B) * C / 2;

            double areaQuadrado = Math.Pow(B, 2.0);

            double areaRetangulo = A * B;





            Console.WriteLine(triangulo);
            Console.WriteLine(areaC);
            Console.WriteLine(areaTrapezio);
            Console.WriteLine(areaQuadrado);
            Console.WriteLine(areaRetangulo);


        }
    }
}
