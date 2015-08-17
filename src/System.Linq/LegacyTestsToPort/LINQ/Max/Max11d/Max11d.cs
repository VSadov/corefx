using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, Maximum occurs as the first element
        public static int Test11d()
        {
            float?[] source = { 14.50f, null, float.NaN, 10.98f, null, 7.5f, 8.6f };
            float? expected = 14.50f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11d();
        }
    }
}
