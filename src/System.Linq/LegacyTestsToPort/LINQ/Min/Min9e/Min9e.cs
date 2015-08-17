using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: string, minimum value occurs as the last element
        public static int Test9e()
        {
            string[] source = { null, null, null, null, "aAa" };
            string expected = "aAa";

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9e();
        }
    }
}
