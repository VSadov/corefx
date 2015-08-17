using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Aggregate
{
    public class Test
    {
        // Type: int, source is empty
        public static long Multiply(long e1, int e2)
        {
            return e1 * e2;
        }

        // overload: seed and func, source has limited number of elements        
        public static int Test2d()
        {
            int[] source = { 5, 6, 2, -4 };
            long seed = 2;
            long expected = -480;

            var actual = source.Aggregate(seed, Multiply);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test2d();
        }
    }
}
