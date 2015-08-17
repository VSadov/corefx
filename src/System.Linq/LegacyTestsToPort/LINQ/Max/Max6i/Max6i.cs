using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, NaN occurs as the last element and the sequence includes null
        public static int Test6i()
        {
            double?[] source = { 6.8, 9.4, 10.8, 0, null, -5.6, double.NaN };
            double? expected = 10.8;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6i();
        }
    }
}
