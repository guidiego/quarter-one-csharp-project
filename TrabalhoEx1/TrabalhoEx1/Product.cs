using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoEx1
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double GetSellPrice()
        {
            if (this.Price < 20)
                return this.Price + (this.Price * 0.45);


            return this.Price + (this.Price * 0.3);
        }
    }
}
