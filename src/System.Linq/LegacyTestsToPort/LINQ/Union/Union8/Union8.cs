using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // first and second has repeated elements between and among themselves
        public static int Test8()
        {
            int?[] first = { 1, 2, 3, 4, null, 5, 1 };
            int?[] second = { 6, 2, 3, 4, 5, 6 };
            int?[] expected = { 1, 2, 3, 4, null, 5, 6 };

            var actual = first.Union(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
