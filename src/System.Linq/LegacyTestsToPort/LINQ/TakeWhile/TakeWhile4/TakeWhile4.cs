using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TakeWhile
{
    public class Test
    {
        // index=0, corresponds to the first element
        public static int Test4()
        {
            int[] source = {6, 2, 5, 3, 8};
            int[] expected = {6};

            var actual = source.TakeWhile((element, index) => (index==0));
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
