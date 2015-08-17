using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal, source has only one element
        public static int Test7b()
        {
            decimal[] source = { 20.51m };
            decimal expected = 20.51m;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7b();
        }
    }
}
