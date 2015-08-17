using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Range
{
    public class Test
    {
        // count=1 and start<0
        public static int Test4()
        {
            int start = -5;
            int count = 1;
            int[] expected = {-5}; 

            var actual = Enumerable.Range(start, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
