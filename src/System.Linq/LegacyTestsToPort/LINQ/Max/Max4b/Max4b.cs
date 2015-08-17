using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long?, source has only one element
        public static int Test4b()
        {
            long?[] source = { Int64.MaxValue };
            long? expected = Int64.MaxValue;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4b();
        }
    }
}
