using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float, source has only one element
        public static int Test10b()
        {
            float[] source = { 5.5f };
            float expected = 5.5f;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10b();
        }
    }
}
