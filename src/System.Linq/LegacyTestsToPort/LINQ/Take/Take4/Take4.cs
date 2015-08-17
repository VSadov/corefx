using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Take
{
    public class Test
    {
        // Number of elements in source is >1 and count=1
        public static int Test4()
        {
            int[] source = {2, 5, 9, 1};
            int[] expected = {2};
            int count = 1;

            var actual = source.Take(count);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
