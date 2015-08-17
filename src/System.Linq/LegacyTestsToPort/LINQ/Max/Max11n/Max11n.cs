using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, NaN occurs as the first element and the rest are null's
        public static int Test11n()
        {
            float?[] source = { float.NaN, null, null, null };

            var actual = source.Max();

            return (float.IsNaN((float)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11n();
        }
    }
}
