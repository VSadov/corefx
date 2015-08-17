using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkipWhile
{
    public class Test
    {
        // index=number of elements - 1, corresponds to the last element
        public static int Test5()
        {
            int[] source = {6, 2, 5, 3, 8};
            int[] expected = {8};

            var actual = source.SkipWhile((element, index) => (index<4));
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
