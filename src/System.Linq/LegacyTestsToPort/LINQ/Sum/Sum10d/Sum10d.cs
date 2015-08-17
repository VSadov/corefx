using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float?, source has only null as elements
        public static int Test10d()
        {
            float?[] source = { null, null, null, null };
            float? expected = 0;

            var actual = source.Sum();

            return (expected.Equals(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10d();
        }
    }
}
