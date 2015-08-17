using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, maximum value occurs 2/3 times
        public static int Test10f()
        {
            float[] source = { -5.5f, float.PositiveInfinity, 9.9f, float.PositiveInfinity };
            float expected = float.PositiveInfinity;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10f();
        }
    }
}
