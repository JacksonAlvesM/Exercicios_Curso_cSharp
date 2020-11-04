using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date) 
            : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + Date;
        }
    }
}
