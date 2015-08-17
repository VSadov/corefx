using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, maximum value occurs as the last element
        public static int Test11e()
        {
            float?[] source = { null, null, null, null, null, 0f };
            float? expected = 0f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11e();
        }
    }
}
