using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal, maximum value occurs 2/3 times
        public static int Test7f()
        {
            decimal[] source = { -5.5m, 0m, 9.9m, -5.5m, 9.9m };
            decimal expected = 9.9m;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7f();
        }
    }
}
