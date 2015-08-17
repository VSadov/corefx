using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal, maximum value occurs as the first element
        public static int Test7d()
        {
            decimal[] source = { 122.5m, 4.9m, 10m, 4.7m, 28m };
            decimal expected = 122.5m;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7d();
        }
    }
}
