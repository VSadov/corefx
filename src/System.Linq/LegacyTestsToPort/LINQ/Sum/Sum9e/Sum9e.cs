using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float, Negative Infinity is returned
        public static int Test9e()
        {
            float[] source = { -float.MaxValue, -float.MaxValue };

            float actual = source.Sum();

            return (float.IsNegativeInfinity(actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9e();
        }
    }
}
