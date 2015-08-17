using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Empty
{
    public class Test
    {
        // Type: Empty Sequence of string
        public static int Test2()
        {
            string[] expected = {};

            IEnumerable<string> actual = Enumerable.Empty<string>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
