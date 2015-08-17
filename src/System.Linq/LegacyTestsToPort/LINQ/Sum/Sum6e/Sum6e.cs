using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double?, Positive Infinity is returned 
        public static int Test6e()
        {
            double?[] source = { Double.MaxValue, Double.MaxValue, 0, 0 };

            var actual = source.Sum();

            return (Double.IsPositiveInfinity((double)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6e();
        }
    }
}
