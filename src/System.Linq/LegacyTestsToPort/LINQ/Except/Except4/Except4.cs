using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // first has repeated elements, second has some elements in first and
        // additional elements
        // second has null value
        public static int Test4()
        {
            int?[] first = { 1, 2, 2, 3, 4, 5 };
            int?[] second = { 5, 3, 2, 6, 6, 3, 1, null, null };
            int?[] expected = { 4 };

            var actual = first.Except(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
