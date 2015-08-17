using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float, source has all equal values
        public static int Test10c()
        {
            float[] source = { float.NaN, float.NaN, float.NaN, float.NaN };
            float expected = float.NaN;

            var actual = source.Min();

            return ((expected.Equals(actual)) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10c();
        }
    }
}
