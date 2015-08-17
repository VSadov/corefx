using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: int?, source has only null elements
        public static int Test2d()
        {
            int?[] source = { null, null, null, null, null };
            int? expected = 0;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
