using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefaultIfEmpty
{
    public class Test
    {
        // source is empty, no defaultValue passed
        public static int Test1b()
        {
            int[] source = {};
            int[] expected = {default(int)};

            var actual = source.DefaultIfEmpty();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
