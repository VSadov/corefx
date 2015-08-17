using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int, source has all equal values
        public static int Test1c()
        {
            int[] source = { -2, -2, -2, -2, -2 };
            int expected = -2;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
