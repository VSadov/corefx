using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long?, source is empty
        public static int Test4a()
        {
            long?[] source = { };
            long? expected = 0;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4a();
        }
    }
}
