using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // source is empty
        public static int Test1()
        {
            int[] source = { };
            int[] expected = { };

            var actual = source.Distinct();
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
