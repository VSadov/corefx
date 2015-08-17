using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // All elements in source are identical
        public static int Test2()
        {
            int[] source = { 5, 5, 5, 5, 5, 5 };
            int[] expected = { 5 };

            var actual = source.Distinct();
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
