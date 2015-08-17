using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Range
{
    public class Test
    {
        // count=0
        public static int Test3()
        {
            int start = 5;
            int count = 0;
            int[] expected = {}; 

            var actual = Enumerable.Range(start, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
