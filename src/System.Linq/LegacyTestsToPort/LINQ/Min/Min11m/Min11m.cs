using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, source element has only NaN's
        public static int Test11m()
        {
            float?[] source = { float.NaN, float.NaN, float.NaN };

            var actual = source.Min();

            return (float.IsNaN((float)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11m();
        }
    }
}
