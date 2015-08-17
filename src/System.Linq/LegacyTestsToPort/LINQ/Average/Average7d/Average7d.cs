using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal, source has different values
        public static int Test7d()
        {
            decimal[] source = { 5.5m, -10m, 15.5m, 40.5m, 28.5m };
            decimal expected = 16m;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7d();
        }
    }
}
