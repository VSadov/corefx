using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: string, minimum value occurs 2/3 times
        public static int Test9f()
        {
            string[] source = { "ooo", "www", "www", "ooo", "ooo", "ppp" };
            string expected = "ooo";

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9f();
        }
    }
}
