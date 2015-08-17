using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, source has all null values
        public static int Test11c()
        {
            float?[] source = { null, null, null, null, null };
            float? expected = null;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11c();
        }
    }
}
