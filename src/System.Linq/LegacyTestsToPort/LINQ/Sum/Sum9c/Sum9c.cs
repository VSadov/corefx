using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float, source has limited number of elements
        public static int Test9c()
        {
            float[] source = { 20.45f, 0f, -10.55f, float.NaN };
            float expected = float.NaN;

            var actual = source.Sum();

            return (expected.Equals(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9c();
        }
    }
}
