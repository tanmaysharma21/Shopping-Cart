using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class GreaterThanEqualTo100Exception : Exception
    {
        public GreaterThanEqualTo100Exception(string message) : base(message) {

        }
    }
}
