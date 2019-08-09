using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class LessThan0Exception : Exception
    {
        public LessThan0Exception(string message) : base(message) { }
    }
}
