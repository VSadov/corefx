using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repeat
{
    public class Test
    {
        // count>1 and element is null
        public static int Test5()
        {
            int? element = null;
            int count = 4;
            int?[] expected = {null, null, null, null}; 

            var actual = Enumerable.Repeat(element, count);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
