using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // first and the last elements of "first" and "second" are the same
        // null value is present both in first and second
        public static int Test5()
        {
            int?[] first = { 1, 2, null, 3, 4, 5, 6 };
            int?[] second = { 6, 7, 7, 7, null, 8, 1 };
            int?[] expected = { 1, null, 6 };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
