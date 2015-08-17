using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repeat
{
    public class Test
    {
        // count=1
        public static int Test3()
        {
            int element = -15;
            int count = 1;
            int[] expected = {-15}; 

            var actual = Enumerable.Repeat(element, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
