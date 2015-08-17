using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Take
{
    public class Test
    {
        // Source is empty and count>0
        public static int Test1()
        {
            int[] source = {};
            int[] expected = {};
            int count = 5;

            var actual = source.Take(count);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
