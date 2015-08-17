using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal, minimum value occurs as the last element
        public static int Test7e()
        {
            decimal[] source = { 6.8m, 9.4m, 10m, 0m, 0m, Decimal.MinValue };
            decimal expected = Decimal.MinValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7e();
        }
    }
}
