using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // first is empty and second is non-empty
        // second has null value
        public static int Test2()
        {
            int?[] first = { };
            int?[] second = { -5, 0, null, 1, 2, 9, 2 };
            int?[] expected = { };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
