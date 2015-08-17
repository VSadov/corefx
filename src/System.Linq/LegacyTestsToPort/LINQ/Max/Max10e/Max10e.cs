using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, maximum value occurs as the last element
        public static int Test10e()
        {
            float[] source = { 6.8f, 9.4f, -10f, 0f, float.NaN, 53.6f };
            float expected = 53.6f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10e();
        }
    }
}
