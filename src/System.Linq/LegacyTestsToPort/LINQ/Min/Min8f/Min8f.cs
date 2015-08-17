using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal?, minimum value occurs 2/3 times
        public static int Test8f()
        {
            decimal?[] source = { 6.4m, null, null, Decimal.MinValue, 9.4m, Decimal.MinValue, 10.9m, Decimal.MinValue };
            decimal? expected = Decimal.MinValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8f();
        }
    }
}
