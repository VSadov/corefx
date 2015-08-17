using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double, minimum value occurs 2/3 times
        public static int Test5f()
        {
            double[] source = { -5.5, Double.NegativeInfinity, 9.9, Double.NegativeInfinity };
            double expected = Double.NegativeInfinity;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5f();
        }
    }
}
