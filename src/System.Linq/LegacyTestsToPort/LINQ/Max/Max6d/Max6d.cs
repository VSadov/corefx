using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, Maximum occurs as the first element
        public static int Test6d()
        {
            double?[] source = { 14.50, null, Double.NaN, 10.98, null, 7.5, 8.6 };
            double? expected = 14.50;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6d();
        }
    }
}
