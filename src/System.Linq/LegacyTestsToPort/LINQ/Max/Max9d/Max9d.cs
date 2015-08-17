using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: string, maximum value occurs as the first element
        public static int Test9d()
        {
            string[] source = { "zzz", "aaa", "abcd", "bark", "temp", "cat" };
            string expected = "zzz";

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9d();
        }
    }
}
