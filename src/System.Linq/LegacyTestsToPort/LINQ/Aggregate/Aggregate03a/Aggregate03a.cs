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

        // overload: seed, func and resultSelector, source has no elements        
        public static int Test3a()
        {
            int[] source = { };
            long seed = 2;
            double expected = 7;
            Func<long, double> resultSelector = (x) => x + 5;

            var actual = source.Aggregate(seed, Multiply, resultSelector);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test3a();
        }
    }
}
