using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefaultIfEmpty
{
    public class Test
    {
        // source is empty, defaultValue passed
        public static int Test2a()
        {
            int?[] source = {};
            int? defaultValue = 9;
            int?[] expected = {9};

            var actual = source.DefaultIfEmpty(defaultValue);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
