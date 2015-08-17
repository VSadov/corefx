using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double?, source has all NaN value
        public static int Test6g()
        {
            double?[] source = { -23.5, 0, Double.NaN, 54.3, 0.56 };
            double? expected = Double.NaN;

            var actual = source.Average();

            return ((expected.Equals(actual)) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6g();
        }
    }
}
