using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-2: Elements are in ascending order
        public static int Test7()
        {
            int[] source = { -75, -50, 0, 5, 9, 30, 100 };
            int[] expected = { 100, 30, 9, 5, 0, -50, -75 };

            var actual = source.OrderByDescending((e) => e, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
