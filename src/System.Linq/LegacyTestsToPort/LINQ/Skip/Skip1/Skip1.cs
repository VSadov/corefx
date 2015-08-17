using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Skip
{
    public class Test
    {
        // source is empty and count>0
        public static int Test1()
        {
            int[] source = {};
            int[] expected = {};
            int count = 3;

            var actual = source.Skip(count);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
