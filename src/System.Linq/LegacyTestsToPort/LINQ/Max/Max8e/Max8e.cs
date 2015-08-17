using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal?, Maximum value occurs as the last element
        public static int Test8e()
        {
            decimal?[] source = { null, null, null, null, null, 0m };
            decimal? expected = 0m;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8e();
        }
    }
}
