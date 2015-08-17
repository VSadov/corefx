using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, source has all null values
        public static int Test11c()
        {
            float?[] source = { null, null, null, null, null };
            float? expected = null;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11c();
        }
    }
}
