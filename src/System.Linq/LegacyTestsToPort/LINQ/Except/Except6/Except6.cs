using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // order of elements in first is preserved
        // first and second has null values
        public static int Test6()
        {
            int?[] first = { 2, 3, null, 2, null, 4, 5 };
            int?[] second = { 1, 9, null, 4 };
            int?[] expected = { 2, 3, 5 };

            var actual = first.Except(second);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
