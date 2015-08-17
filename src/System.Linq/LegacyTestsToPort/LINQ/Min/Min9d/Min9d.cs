using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: string, minimum value occurs as the first element
        public static int Test9d()
        {
            string[] source = { "aaa", "abcd", "bark", "temp", "cat" };
            string expected = "aaa";

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9d();
        }
    }
}
