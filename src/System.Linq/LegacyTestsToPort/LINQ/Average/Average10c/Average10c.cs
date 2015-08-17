using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float?, source has all equal values and average is zero
        public static int Test10c()
        {
            float?[] source = { 0f, 0f, 0f, 0f, 0f };
            float? expected = 0f;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10c();
        }
    }
}
