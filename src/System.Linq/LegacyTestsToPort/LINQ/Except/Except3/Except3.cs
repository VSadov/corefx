using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // first is non-empty and second is empty
        // first has null value
        public static int Test3()
        {
            int?[] first = { -6, -8, -6, 2, 0, 0, 5, 6, null, null };
            int?[] second = { };
            int?[] expected = { -6, -8, 2, 0, 5, 6, null };

            var actual = first.Except(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
