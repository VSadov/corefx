using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Skip
{
    public class Test
    {
        // source is >0 and count=0
        public static int Test2()
        {
            int[] source = {3, 100, 4, 10};
            int[] expected = {3, 100, 4, 10};
            int count = 0;

            var actual = source.Skip(count);
            return Verification.Allequal(expected, actual);
        }        


        public static int Main()
        {
            return Test2();
        }
    }
}
