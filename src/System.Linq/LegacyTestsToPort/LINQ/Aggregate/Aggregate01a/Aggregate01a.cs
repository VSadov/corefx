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

        // overload: only func, source has no elements      
        public static int Test1a()
        {
            int[] source = { };

            try
            {
                var actual = source.Aggregate(Accumulate);
                return 1;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
        }

        public static int Main()
        {
            return Test1a();
        }
    }
}
