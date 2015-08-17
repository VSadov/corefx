using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal, minimum value occurs 2/3 times
        public static int Test7f()
        {
            decimal[] source = { -5.5m, 0m, 9.9m, -5.5m, 5m };
            decimal expected = -5.5m;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7f();
        }
    }
}
