using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefaultIfEmpty
{
    public class Test
    {
        // source is non-empty, defaultValue passed
        public static int Test2c()
        {
            int[] source = {3};
            int defaultValue = 9;
            int[] expected = {3};

            var actual = source.DefaultIfEmpty(defaultValue);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2c();
        }
    }
}
