using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Concat
{
    public class Test
    {
        // first is non-empty and second is empty
        public static int Test3()
        {
            int[] first = { 2, 6, 4, 6, 2 };
            int[] second = { };
            int[] expected = { 2, 6, 4, 6, 2 };

            var actual = first.Concat(second);
            return Verification.Allequal(expected, actual);
        }

        public static int Main(string[] args)
        {
            return Test3();
        }
    }
}
