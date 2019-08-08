using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class CartItem : ICartItem
    {
        public IProduct product { get; set; }

        public int Quantity { get; set; }

        public CartItem(IProduct product, int quantity)
        {
            this.product = product;
            Quantity = quantity;
        }

        public int TotalCost()
        {
            return product.Price;
        }
    }
}
