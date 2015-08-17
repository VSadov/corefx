using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: string, maximum value occurs 2/3 times
        public static int Test9f()
        {
            string[] source = { "ooo", "ccc", "ccc", "ooo", "ooo", "nnn" };
            string expected = "ooo";

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9f();
        }
    }
}
