using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal?, source has all null values
        public static int Test8f()
        {
            decimal?[] source = { null, null, null, null, null };
            decimal? expected = null;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8f();
        }
    }
}
