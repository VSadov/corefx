using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double, source has different values
        public static int Test5d()
        {
            double[] source = { 5.5, -10, 15.5, 40.5, 28.5 };
            double expected = 16;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5d();
        }
    }
}
