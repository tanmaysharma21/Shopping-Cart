using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class ShoppingCart
    {
        public readonly List<ICartItem> cartItemList=new List<ICartItem>();
        public IDiscount discount;

        public ShoppingCart(IDiscount discount)
        {
            this.discount = discount;
        }

        public int GetTotalCost()
        {
            int cost = 0;
            foreach(ICartItem cartItem in cartItemList)
            {
                cost += cartItem.TotalCost();
            }

            int discountedCost = cost * (100-discount.DiscountPercentage) / 100;

            return discountedCost;
        }

    }

}
