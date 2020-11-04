using System;
using System.Globalization;

namespace Exercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados d = new Dados();

            Console.WriteLine("Digite nome do funcionariio:");
            d.Nome = Console.ReadLine();

            Console.WriteLine("Digite o salario bruto do funcionario:");
            d.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite quanto de imposto o funcionario paga:");
            d.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            d.SalarioLiquido = d.SalarioBruto - d.Imposto;

            Console.WriteLine("Funcionário:" + d.Nome + ", $" + d.SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            d.AumentarSalario(aumento);

            Console.WriteLine("Dados atualizado:" + d.Nome + ", $" + d.SalarioLiquido.ToString("F2", CultureInfo.InvariantCulture));





            //Exercicio 1
            /*
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine( );

            double areaR = r.Area();
            double perimetroR = r.Perimetro();
            double diagonalR = r.Diagonal();


            Console.WriteLine("Area =" + areaR.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro =" + perimetroR.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal =" + diagonalR.ToString("F2", CultureInfo.InvariantCulture));
            */

        }
    }
}
