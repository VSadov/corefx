using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, maximum value occurs as the last element
        public static int Test6e()
        {
            double?[] source = { null, null, null, null, null, 0 };
            double? expected = 0;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6e();
        }
    }
}
