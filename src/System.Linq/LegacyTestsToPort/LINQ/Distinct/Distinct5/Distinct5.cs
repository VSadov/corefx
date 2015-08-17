using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // First and the Last elements in source are the same
        public static int Test5()
        {
            int[] source = { 1, 2, 3, 4, 5, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            var actual = source.Distinct();
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
