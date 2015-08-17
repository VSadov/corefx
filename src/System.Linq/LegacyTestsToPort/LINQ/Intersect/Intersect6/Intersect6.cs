using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // Elements repeat within and between first and second
        public static int Test6()
        {
            int[] first = { 1, 2, 2, 3, 4, 3, 5 };
            int[] second = { 1, 4, 4, 2, 2, 2 };
            int[] expected = { 1, 2, 4 };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
