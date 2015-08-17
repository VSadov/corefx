using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long?, source has only one element
        public static int Test4b()
        {
            long?[] source = { (long)-Int32.MaxValue - 20 };
            long? expected = (long)-Int32.MaxValue - 20;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4b();
        }
    }
}
