using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: string, source has all equal values
        public static int Test9c()
        {
            string[] source = { "hi", "hi", "hi", "hi" };
            string expected = "hi";

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9c();
        }
    }
}
