using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, source element has only NaN's
        public static int Test10m()
        {
            float[] source = { float.NaN, float.NaN, float.NaN };

            var actual = source.Max();

            return (float.IsNaN(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10m();
        }
    }
}
