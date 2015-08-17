using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, source is empty, null is returned
        public static int Test11a()
        {
            float?[] source = { };
            float? expected = null;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11a();
        }
    }
}
