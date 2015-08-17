using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double, Negative Infinity is returned
        public static int Test5e()
        {
            double[] source = { -Double.MaxValue, -Double.MaxValue };

            double actual = source.Sum();

            return (Double.IsNegativeInfinity(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5e();
        }
    }
}
