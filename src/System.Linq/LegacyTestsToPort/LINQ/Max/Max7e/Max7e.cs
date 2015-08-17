using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal, maximum value occurs as the last element
        public static int Test7e()
        {
            decimal[] source = { 6.8m, 9.4m, 10m, 0m, 0m, Decimal.MaxValue };
            decimal expected = Decimal.MaxValue;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7e();
        }
    }
}
