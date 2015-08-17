using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double, source has NaN
        public static int Test5e()
        {
            double[] source = { 5.58, Double.NaN, 30, 4.55, 19.38 };
            double expected = Double.NaN;

            var actual = source.Average();

            return ((expected.Equals(actual)) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5e();
        }
    }
}
