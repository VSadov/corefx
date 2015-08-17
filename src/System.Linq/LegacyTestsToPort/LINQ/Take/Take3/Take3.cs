using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Take
{
    public class Test
    {
        // Number of elements in source is >0 and count=0
        public static int Test3()
        {
            int[] source = {2, 5, 9, 1};
            int[] expected = {};
            int count = 0;

            var actual = source.Take(count);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
