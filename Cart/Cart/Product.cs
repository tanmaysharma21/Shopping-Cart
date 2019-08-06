using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ProductID { get; set; }

        public Product(string name, int price, int id)
        {
            Name = name;
            Price = price;
            ProductID = id;
        }

    }
}
