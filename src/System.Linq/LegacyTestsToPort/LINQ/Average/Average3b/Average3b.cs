using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long, source has only one element
        public static int Test3b()
        {
            long[] source = { Int64.MaxValue };
            double expected = Int64.MaxValue;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3b();
        }
    }
}
