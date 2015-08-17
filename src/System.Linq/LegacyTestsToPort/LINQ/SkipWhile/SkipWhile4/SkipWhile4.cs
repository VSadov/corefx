using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkipWhile
{
    public class Test
    {
        // index=0, corresponds to the first element
        public static int Test4()
        {
            int[] source = {6, 2, 5, 3, 8};
            int[] expected = {2, 5, 3, 8};

            var actual = source.SkipWhile((element, index) => (index==0));
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
