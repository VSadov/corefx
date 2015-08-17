using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Skip
{
    public class Test
    {
        // source is >1 and count=1
        public static int Test4()
        {
            int?[] source = {3, 100, 4, null, 10};
            int?[] expected = {100, 4, null, 10};
            int count = 1;

            var actual = source.Skip(count);
            return Verification.Allequal(expected, actual);
        }        


        public static int Main()
        {
            return Test4();
        }
    }
}
