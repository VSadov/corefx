using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, source has only one element
        public static int Test8b()
        {
            decimal?[] source = { Decimal.MinValue };
            decimal? expected = Decimal.MinValue;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8b();
        }
    }
}
