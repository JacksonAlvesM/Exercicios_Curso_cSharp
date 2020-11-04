using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exercicio
{
    class Mercadoria
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public double Quantidade { get; set; }

        public Mercadoria()
        {
        }

        public Mercadoria(string nome, double preco, double quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double Total()
        {
            return Preco * Quantidade;
        }
    }
}
