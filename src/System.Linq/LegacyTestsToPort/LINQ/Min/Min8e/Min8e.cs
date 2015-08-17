using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal?, Minimum value occurs as the last element
        public static int Test8e()
        {
            decimal?[] source = { null, null, null, null, null, 0m };
            decimal? expected = 0m;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8e();
        }
    }
}
