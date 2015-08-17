using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, Minimum occurs as the first element
        public static int Test11d()
        {
            float?[] source = { -4.50f, null, 10.98f, null, 7.5f, 8.6f };
            float? expected = -4.50f;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11d();
        }
    }
}
