using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToSequence
{
    public class Test
    {
        // source has only one element
        public static int Test2()
        {
            int[] source = {2};
            int[] expected = {2};

            var actual = source.AsEnumerable();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
