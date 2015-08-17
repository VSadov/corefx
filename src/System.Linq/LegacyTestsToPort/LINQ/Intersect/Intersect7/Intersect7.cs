using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // first and second has the same elements
        public static int Test7()
        {
            int[] first = { 1, 1, 1, 1, 1, 1 };
            int[] second = { 1, 1, 1, 1, 1 };
            int[] expected = { 1 };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
