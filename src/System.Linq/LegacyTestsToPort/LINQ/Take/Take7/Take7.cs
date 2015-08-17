using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Take
{
    public class Test
    {
        // Number of elements in source is >0 and count=Number of elements in source + 1
        public static int Test7()
        {
            int?[] source = {2, 5, null, 9, 1};
            int?[] expected = {2, 5, null, 9, 1};
            int count = 6;

            var actual = source.Take(count);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
