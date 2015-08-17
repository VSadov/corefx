using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double, source has only one element
        public static int Test5b()
        {
            double[] source = { 5.5 };
            double expected = 5.5;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5b();
        }
    }
}
