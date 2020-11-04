using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            double value = Price - CustomsFee;
            return value.ToString();
        }
    }
}
