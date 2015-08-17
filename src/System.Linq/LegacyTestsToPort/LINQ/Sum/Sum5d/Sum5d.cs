using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double, Positive Infinity is returned 
        public static int Test5d()
        {
            double[] source = { Double.MaxValue, Double.MaxValue, 0, 0 };

            double actual = source.Sum();

            return (Double.IsPositiveInfinity(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5d();
        }
    }
}
