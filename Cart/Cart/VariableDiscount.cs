using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class VariableDiscount : IDiscount
    {
        int discountPercentage;
        public VariableDiscount(int discountPercentage)
        {
            this.discountPercentage = discountPercentage;
        }

        public int DiscountPercentage(ICartItem cartItem)
        {
            return discountPercentage * cartItem.TotalCost() / 100;
        }

        
    }
}
