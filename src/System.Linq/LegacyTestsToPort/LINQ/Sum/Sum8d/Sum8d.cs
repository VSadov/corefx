using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal?, source has only null elements
        public static int Test8d()
        {
            decimal?[] source = { null, null, null };
            decimal? expected = 0;

            var actual = source.Sum();

            return (expected.Equals(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8d();
        }
    }
}
