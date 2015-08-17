using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal?, source has only one element
        public static int Test8b()
        {
            decimal?[] source = { Decimal.MaxValue };
            decimal? expected = Decimal.MaxValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8b();
        }
    }
}
