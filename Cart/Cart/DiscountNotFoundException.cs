using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class DiscountNotFoundException : Exception
    {
        public DiscountNotFoundException(string message) : base(message) { }
    }
}
