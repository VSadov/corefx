using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double?, source has 1 non-null value
        public static int Test6e()
        {
            double?[] source = { null, null, null, null, 45 };
            double? expected = 45;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6e();
        }
    }
}
