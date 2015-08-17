using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long, minimum value occurs 2/3 times
        public static int Test3f()
        {
            long[] source = { 6, -5, 9, -5, 10, -5 };
            long expected = -5;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3f();
        }
    }
}
