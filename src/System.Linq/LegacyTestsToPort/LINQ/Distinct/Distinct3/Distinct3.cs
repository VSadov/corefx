using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // All elements in source are unique
        public static int Test3()
        {
            int[] source = { 2, -5, 0, 6, 10, 9 };
            int[] expected = { 2, -5, 0, 6, 10, 9 };

            var actual = source.Distinct();
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
