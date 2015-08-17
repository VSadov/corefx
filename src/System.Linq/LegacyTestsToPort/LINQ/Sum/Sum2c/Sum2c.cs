using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: int?, source has limited number of elements includes null
        public static int Test2c()
        {
            int?[] source = { 20, 0, -30, null, null, -4 };
            int? expected = -14;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2c();
        }
    }
}
