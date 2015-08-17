using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefaultIfEmpty
{
    public class Test
    {
        // source is non-empty, no defaultValue passed
        public static int Test1c()
        {
            int[] source = {3};
            int[] expected = {3};

            var actual = source.DefaultIfEmpty();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
