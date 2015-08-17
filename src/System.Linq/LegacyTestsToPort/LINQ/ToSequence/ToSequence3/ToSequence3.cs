using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToSequence
{
    public class Test
    {
        // source has limited number of elements
        public static int Test3()
        {
            int?[] source = {-5, 0, 1, -4, 3, null, 10};
            int?[] expected = {-5, 0, 1, -4, 3, null, 10};

            var actual = source.AsEnumerable();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
