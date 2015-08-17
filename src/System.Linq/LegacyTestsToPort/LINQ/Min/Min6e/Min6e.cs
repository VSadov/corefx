using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, minimum value occurs as the last element
        public static int Test6e()
        {
            double?[] source = { null, null, null, null, null, 0 };
            double? expected = 0;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6e();
        }
    }
}
