using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, NaN occurs as the last element and the sequence includes null
        public static int Test11j()
        {
            float?[] source = { 6.8f, 9.4f, 10f, 0, null, -5.6f, float.NaN };
            float? expected = 10f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11j();
        }
    }
}
