using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Range
{
    public class Test
    {
        // count>1
        public static int Test5()
        {
            int start = 12;
            int count = 6;
            int[] expected = {12, 13, 14, 15, 16, 17}; 

            var actual = Enumerable.Range(start, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
