using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long?, source has only null elements
        public static int Test4d()
        {
            long?[] source = { null, null, null, null, null };
            long? expected = 0;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4d();
        }
    }
}
