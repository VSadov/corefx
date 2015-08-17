using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Aggregate
{
    public class Test
    {
        // Type: int, source is empty

        public static int Accumulate(int e1, int e2)
        {
            return e1 + e2;
        }

        // overload: only func, source has limited number of elements        
        public static int Test1d()
        {
            int[] source = { 5, 6, 0, -4 };
            int expected = 7;

            var actual = source.Aggregate(Accumulate);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test1d();
        }
    }
}
