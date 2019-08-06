using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public interface ICartItem
    {
        IProduct product { get; set; }

        int Quantity { get; set; }

        int TotalCost();

    }
}
