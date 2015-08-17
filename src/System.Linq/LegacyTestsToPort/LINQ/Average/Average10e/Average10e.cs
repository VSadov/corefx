using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float?, source has 1 non-null value
        public static int Test10e()
        {
            float?[] source = { null, null, null, null, 45f };
            float? expected = 45f;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10e();
        }
    }
}
