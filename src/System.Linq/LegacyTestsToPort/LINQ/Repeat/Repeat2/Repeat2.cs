using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repeat
{
    public class Test
    {
        // count=0
        public static int Test2()
        {
            int element = -15;
            int count = 0;
            int[] expected = {}; 

            var actual = Enumerable.Repeat(element, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
