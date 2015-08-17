using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, NaN occurs as the 1st element and the other element is -ve infinity
        public static int Test10k()
        {
            float[] source = { float.NaN, float.NegativeInfinity };
            float expected = float.NegativeInfinity;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10k();
        }
    }
}
