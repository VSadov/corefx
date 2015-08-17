using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repeat
{
    public class Test
    {
        // count>1
        public static int Test4()
        {
            int element = 12;
            int count = 8;
            int[] expected = {12, 12, 12, 12, 12, 12, 12, 12}; 

            var actual = Enumerable.Repeat(element, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
