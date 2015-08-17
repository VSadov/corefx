using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal?, Minimum occurs as the first element
        public static int Test8d()
        {
            decimal?[] source = { -4.50m, null, null, 10.98m, null, 7.5m, 8.6m };
            decimal? expected = -4.50m;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8d();
        }
    }
}
