using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double?, source has only one element
        public static int Test6b()
        {
            double?[] source = { 20.51 };
            double? expected = 20.51;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6b();
        }
    }
}
