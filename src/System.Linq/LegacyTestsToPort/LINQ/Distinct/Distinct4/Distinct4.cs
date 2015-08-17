using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // Elements in source are of the form: 111222
        // Element has a null value
        public static int Test4()
        {
            int?[] source = { 1, 1, 1, 2, 2, 2, null, null };
            int?[] expected = { 1, 2, null };

            var actual = source.Distinct();
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
