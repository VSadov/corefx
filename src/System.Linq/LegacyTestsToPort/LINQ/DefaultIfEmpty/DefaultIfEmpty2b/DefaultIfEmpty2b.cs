using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefaultIfEmpty
{
    public class Test
    {
        // source is empty, defaultValue passed
        public static int Test2b()
        {
            int[] source = {};
            int defaultValue = -10;
            int[] expected = {-10};

            var actual = source.DefaultIfEmpty(defaultValue);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
