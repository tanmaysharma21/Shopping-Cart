using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class FixedDiscount : IDiscount
    {
        public FixedDiscount()
        {
            DiscountPercentage = 10;
        }

        public int DiscountPercentage { get; set; }
    }
}
