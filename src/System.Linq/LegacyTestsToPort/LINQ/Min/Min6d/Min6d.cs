using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, Minimum occurs as the first element
        public static int Test6d()
        {
            double?[] source = { -4.50, null, 10.98, null, 7.5, 8.6 };
            double? expected = -4.50;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6d();
        }
    }
}
