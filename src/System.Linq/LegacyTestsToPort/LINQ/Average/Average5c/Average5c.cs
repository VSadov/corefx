using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double, source has all equal values and average is zero
        public static int Test5c()
        {
            double[] source = { 0.0, 0.0, 0.0, 0.0, 0.0 };
            double expected = 0;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5c();
        }
    }
}
