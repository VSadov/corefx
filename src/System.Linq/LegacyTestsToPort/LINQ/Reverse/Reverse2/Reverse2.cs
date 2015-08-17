using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Reverse
{
    public class Test
    {
        // source has only one element
        public static int Test2()
        {
            int[] source = {5};
            int[] expected = {5};

            var actual = source.Reverse();

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test2();
        }
    }
}
