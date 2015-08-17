using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Take
{
    public class Test
    {
        // Number of elemnets in source is >0 and count<0
        public static int Test2()
        {
            int[] source = {2, 5, 9, 1};
            int[] expected = {};
            int count = -5;

            var actual = source.Take(count);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
