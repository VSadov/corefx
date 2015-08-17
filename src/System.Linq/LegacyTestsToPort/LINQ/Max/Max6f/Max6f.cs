using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, maximum value occurs 2/3 times
        public static int Test6f()
        {
            double?[] source = { -6.4, null, null, -0.5, -9.4, -0.5, -10.9, -0.5 };
            double? expected = -0.5;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6f();
        }
    }
}
