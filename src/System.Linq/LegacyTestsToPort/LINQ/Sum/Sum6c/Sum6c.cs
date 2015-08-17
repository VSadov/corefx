using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double?, source has limited number of elements
        public static int Test6c()
        {
            double?[] source = { 20.45, 0, -10.55, Double.NaN };
            double? expected = Double.NaN;

            var actual = source.Sum();

            return (expected.Equals(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6c();
        }
    }
}
