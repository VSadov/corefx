using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float?, Positive Infinity is returned 
        public static int Test10e()
        {
            float?[] source = { float.MaxValue, float.MaxValue, 0f, 0f };

            var actual = source.Sum();

            return (float.IsPositiveInfinity((float)actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10e();
        }
    }
}
