using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // first is empty and second is non-empty
        public static int Test2()
        {
            int[] first = { };
            int[] second = { -6, -8, -6, 2, 0, 0, 5, 6 };
            int[] expected = { };

            var actual = first.Except(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
