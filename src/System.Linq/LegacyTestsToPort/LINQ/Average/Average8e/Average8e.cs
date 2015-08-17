using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, source has 1 non-null value
        public static int Test8e()
        {
            decimal?[] source = { null, null, null, null, 45m };
            decimal? expected = 45m;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8e();
        }
    }
}
