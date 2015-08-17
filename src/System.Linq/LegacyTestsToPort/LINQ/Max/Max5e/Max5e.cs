using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, maximum value occurs as the last element
        public static int Test5e()
        {
            double[] source = { 6.8, 9.4, -10, 0, Double.NaN, 53.6 };
            double expected = 53.6;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5e();
        }
    }
}
