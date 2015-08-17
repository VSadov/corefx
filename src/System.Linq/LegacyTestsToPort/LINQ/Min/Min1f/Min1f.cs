using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int, minimum value occurs 2/3 times
        public static int Test1f()
        {
            int[] source = { 6, 0, 9, 0, 10, 0 };
            int expected = 0;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1f();
        }
    }
}
