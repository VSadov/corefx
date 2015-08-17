using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double, source has only one element
        public static int Test5b()
        {
            double[] source = { Double.MaxValue };
            double expected = Double.MaxValue;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5b();
        }
    }
}
