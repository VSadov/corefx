using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float?, source has different values
        public static int Test10d()
        {
            float?[] source = { 5.5f, 0, null, null, null, 15.5f, 40.5f, null, null, -23.5f };
            float? expected = 7.6f;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10d();
        }
    }
}
