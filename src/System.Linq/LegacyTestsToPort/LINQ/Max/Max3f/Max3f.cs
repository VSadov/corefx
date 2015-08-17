using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, maximum value occurs 2/3 times
        public static int Test3f()
        {
            long[] source = { 6, 50, 9, 50, 10, 50 };
            long expected = 50;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3f();
        }
    }
}
