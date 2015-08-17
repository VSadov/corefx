using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, maximum value occurs 2/3 times
        public static int Test5f()
        {
            double[] source = { -5.5, Double.PositiveInfinity, 9.9, Double.PositiveInfinity };
            double expected = Double.PositiveInfinity;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5f();
        }
    }
}
