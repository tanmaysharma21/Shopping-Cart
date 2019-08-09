using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class FixedDiscount : IDiscount
    {
        int discountPercentage=10;

        public void UpdateFixedDiscount(int discountPercentage)
        {
            if (discountPercentage < 0)
                throw new LessThan0Exception("Discount percentage must be greater than 0");
            if (discountPercentage>=100)
                throw new GreaterThanEqualTo100Exception("Discount percentage must be less than 100");
            this.discountPercentage = discountPercentage;
        }

        public int DiscountPercentage (ICartItem cartItem)
        {
            return discountPercentage * cartItem.TotalCost()/100;
        }
    }
}
