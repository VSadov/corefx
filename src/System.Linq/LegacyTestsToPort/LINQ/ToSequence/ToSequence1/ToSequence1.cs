using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToSequence
{
    public class Test
    {
        // source is null
        public static int Test1()
        {
            int[] source = null;
            IEnumerable<int> expected = null;

            var actual = source.AsEnumerable();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
