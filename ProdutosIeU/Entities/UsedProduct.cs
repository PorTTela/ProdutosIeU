using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProdutosIeU.Entities
{
    class UsedProduct : Product
    {
        public DateTime Manufacture { get; private set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacture) :base(name, price)
        {
            Manufacture = manufacture;
        }

        public sealed override string PriceTag()
        {
            return Name + " (used), $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + Manufacture.ToString("dd/MM/yyyy") + ")" ;
        }
    }
}
