using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, maximum value occurs as the first element
        public static int Test10d()
        {
            float[] source = { 112.5f, 4.9f, 30f, 4.7f, 28f };
            float expected = 112.5f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10d();
        }
    }
}
