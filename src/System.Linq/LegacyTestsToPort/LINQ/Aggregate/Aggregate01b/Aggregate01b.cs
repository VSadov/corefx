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

        // overload: only func, source has one element        
        public static int Test1b()
        {
            int[] source = { 5 };
            int expected = 5;

            var actual = source.Aggregate(Accumulate);

            return ((expected == actual) ? 0 : 1);
        }

        public static int Main()
        {
            return Test1b();
        }
    }
}
