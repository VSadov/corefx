using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: string, source has only one element
        public static int Test9b()
        {
            string[] source = { "Hello" };
            string expected = "Hello";

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9b();
        }
    }
}
