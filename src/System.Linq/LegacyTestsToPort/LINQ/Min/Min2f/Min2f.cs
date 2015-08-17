using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int, minimum value occurs 2/3 times
        public static int Test2f()
        {
            int?[] source = { 6, null, null, 0, 9, 0, 10, 0 };
            int? expected = 0;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2f();
        }
    }
}
