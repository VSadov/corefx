using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: int?, Maximum value occurs 2/3 times
        public static int Test2f()
        {
            int?[] source = { 6, null, null, 100, 9, 100, 10, 100 };
            int? expected = 100;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2f();
        }
    }
}
