using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, minimum value occurs 2/3 times
        public static int Test11f()
        {
            float?[] source = { 6.4f, null, null, -0.5f, 9.4f, -0.5f, 10.9f, -0.5f };
            float? expected = -0.5f;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11f();
        }
    }
}
