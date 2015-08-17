using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal, source has only one element
        public static int Test7b()
        {
            decimal[] source = { 5.5m };
            decimal expected = 5.5m;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7b();
        }
    }
}
