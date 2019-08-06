using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class ShoppingCart
    {
        public readonly List<ICartItem> cartItemList=new List<ICartItem>();

        public int GetTotalCost()
        {
            int cost = 0;
            foreach(ICartItem cartItem in cartItemList)
            {
                cost += cartItem.TotalCost();
            }

            return cost;
        }

    }
}
