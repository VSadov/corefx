using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // first is empty and second is empty
        public static int Test1()
        {
            int[] first = { };
            int[] second = { };
            int[] expected = { };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
