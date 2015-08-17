using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Reverse
{
    public class Test
    {
        // source has duplicate elements
        public static int Test3()
        {
            int?[] source = {-10, 0, 5, null, 0, 9, 100, null, 9};
            int?[] expected = {9, null, 100, 9, 0, null, 5, 0, -10};

            var actual = source.Reverse();

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test3();
        }
    }
}
