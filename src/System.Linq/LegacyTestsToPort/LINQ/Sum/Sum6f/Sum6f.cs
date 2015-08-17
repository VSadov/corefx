using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double?, Negative Infinity is returned
        public static int Test6f()
        {
            double?[] source = { -Double.MaxValue, -Double.MaxValue };

            double? actual = source.Sum();

            return (Double.IsNegativeInfinity((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6f();
        }
    }
}
