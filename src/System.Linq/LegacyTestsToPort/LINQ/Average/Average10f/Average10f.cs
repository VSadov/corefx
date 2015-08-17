using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float?, source has all null values
        public static int Test10f()
        {
            float?[] source = { null, null, null, null, null };
            float? expected = null;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10f();
        }
    }
}
