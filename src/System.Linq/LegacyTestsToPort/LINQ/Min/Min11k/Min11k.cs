using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, NaN occurs as the 1st element and the other element is -ve infinity
        public static int Test11k()
        {
            float?[] source = { float.NaN, float.NegativeInfinity };

            var actual = source.Min();

            return (float.IsNaN((float)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11k();
        }
    }
}
