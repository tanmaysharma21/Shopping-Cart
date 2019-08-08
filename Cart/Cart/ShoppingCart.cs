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

        public int GetTotalCostAfterDiscount()
        {
            int cost = 0;
            foreach(ICartItem cartItem in cartItemList)
            {
                cost = cost + cartItem.TotalCost() - discount.DiscountPercentage(cartItem);
            }

            return cost;
        }



    }

}
