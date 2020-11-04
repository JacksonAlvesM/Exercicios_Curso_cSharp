using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados funcionario1, funcionario2;
            funcionario1 = new Dados();
            funcionario2 = new Dados();


            Console.WriteLine("Dados do primeiro funcionário:");
            funcionario1.nome = Console.ReadLine();
            funcionario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            funcionario2.nome = Console.ReadLine();
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (funcionario1.salario + funcionario2.salario) / 2;

            Console.WriteLine("Salário medio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));


            //Exercicio 1
            /*
            Dados pessoa1, pessoa2;
            pessoa1 = new Dados();
            pessoa2 = new Dados();
          

            Console.WriteLine("Dados da primeira pessoa:");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: {0}", pessoa1.nome);
            Console.WriteLine("Idade: {0}", pessoa1.idade);

            Console.WriteLine("Dados da segunda pessoa:");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Idade: " + pessoa2.idade);

            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.nome);
            }
            */

        }
    }
}
