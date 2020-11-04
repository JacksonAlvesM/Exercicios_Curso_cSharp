using System;
using System.Globalization;

namespace Modulo03_Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 6 (não resolvido)
            Console.WriteLine("Selecione sua renda.");

            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double insencao = renda - 2000;           
            double impostoRenda18 = 0;
            double impostoRenda08 = 0;
            double impostoRenda28 = 0;
            double valorFinal = 0;



            if (insencao <= 0)
            {
                Console.WriteLine("Isento");
            }
            else if (insencao >0 && insencao < 1000)
            {
                impostoRenda08 = insencao * 0.08;

                Console.WriteLine("Imposto de renda de: " + impostoRenda08.ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (insencao >= 1000 && insencao <= 1500)
            {
                impostoRenda18 = (insencao - 1000) * 0.18;
                impostoRenda08 = (int)insencao / 1000 * 1000 * 0.08;
                valorFinal = impostoRenda08 + impostoRenda18;
                

                Console.WriteLine("Imposto de renda de: " +valorFinal.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {
                impostoRenda28 = (insencao - 2500) * 0.28;
                impostoRenda18 = (int)insencao / 3000 * 3000 * 0.18;
                valorFinal = impostoRenda18 + impostoRenda28;


                Console.WriteLine("Imposto de renda de: " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }




            //Exercicio 7
            /*
            Console.WriteLine("Selecione o valor de X e Y:");

            string[] vet = Console.ReadLine().Split();
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);

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
            */

            //Exercicio 6
            /*
            Console.WriteLine("Selecione um valor:");
            float valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >=  0.25 && valor < 25.50)
            {
                Console.WriteLine("Intervalo de: 0,25 " );
            }
            else if (valor >= 25.50 && valor <50.75)
            {
                Console.WriteLine("Intervalo de: 25,50 ");
            }
            else if (valor >= 50.75 && valor < 75.100)
            {
                Console.WriteLine("Intervalo de: 50,75 ");
            }
            else if (valor >= 75.100 && valor < 100.00)
            {
                Console.WriteLine("Intervalo de: 75,100 ");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
            */


            //Exercicio 5
            /*
            Console.WriteLine("Digite o codigo do produto ea quantidade:");

            string[] vet = Console.ReadLine().Split();
            double produto = double.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            double valorProduto = 00.00;


            if (produto == 1)
            {
                valorProduto = 4.00 * quantidade;
                Console.WriteLine("Preço:" + valorProduto.ToString("F2", CultureInfo.InvariantCulture), "reais");


            }
            else if (produto == 2)
            {
                valorProduto = 4.50 * quantidade;
                Console.WriteLine("Preço:" + valorProduto.ToString("F2", CultureInfo.InvariantCulture), "reais");


            }
            else if (produto == 3)
            {
                valorProduto = 5.00 * quantidade;
                Console.WriteLine("Preço:" + valorProduto.ToString("F2", CultureInfo.InvariantCulture), "reais");


            }
            else if (produto == 4)
            {
                valorProduto = 2.00 * quantidade;
                Console.WriteLine("Preço:" + valorProduto.ToString("F2", CultureInfo.InvariantCulture), "reais");


            }
            else if (produto == 5)
            {
                valorProduto = 1.50 * quantidade;
                Console.WriteLine("Preço:" + valorProduto.ToString("F2", CultureInfo.InvariantCulture), "reais");


            }
            else
            {
                Console.WriteLine("Codigo não existe!");
            }
            */



            //Exercicio 4 
            /*
            Console.WriteLine("Selecione horas inicial e horas final:");

            string[] vet = Console.ReadLine().Split();
            int tempoInicial = int.Parse(vet[0]);
            int tempoFinal = int.Parse(vet[1]);

            int intervalo = tempoFinal - tempoInicial;

            if (intervalo < 0)
            {
                int intervaloN = intervalo + 24;
                Console.WriteLine("Intervalo de: " + intervaloN );
            }
            else
            {
                Console.WriteLine("intervalo de: " + intervalo );
            }
            */


            //Exercicio 3
            /*
            Console.WriteLine("Selecione dois numeros inteiros!");
            string[] vet = Console.ReadLine().Split();
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            if (x % 2 == 0 && y % 2 == 0 )
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
            */


            //Exercicio 1
            /*
            Console.WriteLine("Entre com um numero inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x < 0 )
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Positivo");
            }
            */
        }
    }
}
