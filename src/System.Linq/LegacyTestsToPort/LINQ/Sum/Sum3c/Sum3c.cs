using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long, source has limited number of elements
        public static int Test3c()
        {
            long[] source = { Int32.MaxValue, 0, -10, 4, 20 };
            long expected = (long)Int32.MaxValue + 14;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3c();
        }
    }
}
