using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float, source has only one element
        public static int Test9b()
        {
            float[] source = { 20.51f };
            float expected = 20.51f;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9b();
        }
    }
}
