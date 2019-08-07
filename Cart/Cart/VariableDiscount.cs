using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class VariableDiscount : IDiscount
    {
        public VariableDiscount(int discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public int DiscountPercentage { get; set; }
    }
}
