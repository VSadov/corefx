using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Skip
{
    public class Test
    {
        // source is >0 and count=Number of elements in source
        public static int Test5()
        {
            int[] source = {3, 100, 4, 10};
            int[] expected = {};
            int count = 4;

            var actual = source.Skip(count);
            return Verification.Allequal(expected, actual);
        }        


        public static int Main()
        {
            return Test5();
        }
    }
}
