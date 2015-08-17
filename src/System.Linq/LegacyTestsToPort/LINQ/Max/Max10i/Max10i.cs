using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, NaN occurs as the 1st element
        public static int Test10i()
        {
            float[] source = { float.NaN, 6.8f, 9.4f, 10f, 0, -5.6f };
            float expected = 10f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10i();
        }
    }
}
