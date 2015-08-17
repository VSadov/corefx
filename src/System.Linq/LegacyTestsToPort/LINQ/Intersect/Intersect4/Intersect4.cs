using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // first and second has all distinct elements
        public static int Test4()
        {
            int[] first = { -5, 3, -2, 6, 9 };
            int[] second = { 0, 5, 2, 10, 20 };
            int[] expected = { };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
