using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // first is empty and second is empty
        public static int Test1()
        {
            int[] first = { };
            int[] second = { };
            int[] expected = { };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
