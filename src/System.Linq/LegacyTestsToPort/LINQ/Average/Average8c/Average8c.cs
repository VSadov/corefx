using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, source has all equal values and average is zero
        public static int Test8c()
        {
            decimal?[] source = { 0m, 0m, 0m, 0m, 0m };
            decimal? expected = 0m;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8c();
        }
    }
}
