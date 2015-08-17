using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long?, source has limited number of elements includes null
        public static int Test4c()
        {
            long?[] source = { (long)Int32.MaxValue, 0, -30, null, null, -4, 100 };
            long? expected = (long)Int32.MaxValue + 66;

            var actual = source.Sum();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4c();
        }
    }
}
