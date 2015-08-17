using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // Multiple elements repeat non-consecutively
        public static int Test6()
        {
            int[] source = { 1, 1, 2, 2, 4, 3, 1, 3, 2 };
            int[] expected = { 1, 2, 4, 3 };

            var actual = source.Distinct();
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
