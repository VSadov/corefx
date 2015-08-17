using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, source has all equal values
        public static int Test3c()
        {
            long[] source = { 500, 500, 500, 500, 500 };
            long expected = 500;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3c();
        }
    }
}
