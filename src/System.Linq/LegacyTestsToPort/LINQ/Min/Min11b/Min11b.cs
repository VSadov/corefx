using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, source has only one element
        public static int Test11b()
        {
            float?[] source = { float.MinValue };
            float? expected = float.MinValue;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11b();
        }
    }
}
