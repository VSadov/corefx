using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, source has only one element
        public static int Test6b()
        {
            double?[] source = { Double.MinValue };
            double? expected = Double.MinValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6b();
        }
    }
}
