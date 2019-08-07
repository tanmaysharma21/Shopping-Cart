using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public interface IDiscount
    {
        int DiscountPercentage { get; set; }

    }
}
