using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, source has all equal values
        public static int Test5c()
        {
            double[] source = { Double.NaN, Double.NaN, Double.NaN, Double.NaN };
            double expected = Double.NaN;

            var actual = source.Max();

            return ((expected.Equals(actual)) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5c();
        }
    }
}
