using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long?, source has 1 non-null value
        public static int Test4e()
        {
            long?[] source = { null, null, null, null, 50 };
            double? expected = 50;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4e();
        }
    }
}
