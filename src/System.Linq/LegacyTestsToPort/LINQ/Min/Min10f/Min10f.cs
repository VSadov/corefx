using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, minimum value occurs 2/3 times
        public static int Test10f()
        {
            float[] source = { -5.5f, float.NegativeInfinity, 9.9f, float.NegativeInfinity };
            float expected = float.NegativeInfinity;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10f();
        }
    }
}
