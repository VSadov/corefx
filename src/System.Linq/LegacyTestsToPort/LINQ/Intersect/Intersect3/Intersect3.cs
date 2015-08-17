using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // first is non-empty and second is empty
        // first has null value
        public static int Test3()
        {
            int?[] first = { -5, 0, 1, 2, null, 9, 2 };
            int?[] second = { };
            int?[] expected = { };

            var actual = first.Intersect(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
