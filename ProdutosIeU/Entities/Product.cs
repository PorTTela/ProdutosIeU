using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace ProdutosIeU.Entities
{
    class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            this.Price = price;
        }

        public virtual string PriceTag()
        {
           return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
