using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class DiscountFactory
    {
        public IDiscount GetTypeOfDiscount(string discount)
        {
            if (discount.ToLowerInvariant().Equals("fixed discount"))
                return new FixedDiscount();

            if (discount.ToLowerInvariant().Equals("category discount"))
                return new CategoryDiscount();

            try
            {
                int variableDiscount = Convert.ToInt32(discount);
                return new VariableDiscount(variableDiscount);
            }
            catch (Exception e)
            {
                throw new DiscountNotFoundException("Invalid Discount");
            }
        }
    }
}
