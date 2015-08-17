using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, maximum value occurs as the first element
        public static int Test5d()
        {
            double[] source = { 112.5, 4.9, 30, 4.7, 28 };
            double expected = 112.5;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5d();
        }
    }
}
