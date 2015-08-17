using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal?, maximum value occurs 2/3 times
        public static int Test8f()
        {
            decimal?[] source = { 6.4m, null, null, Decimal.MaxValue, 9.4m, Decimal.MaxValue, 10.9m, Decimal.MaxValue };
            decimal? expected = Decimal.MaxValue;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8f();
        }
    }
}
