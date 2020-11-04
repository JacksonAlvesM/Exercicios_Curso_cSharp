using System;


namespace Exercicio3
{    
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ValorParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            double juros = total * Iof;
            return total - juros;
        }

    }
}
