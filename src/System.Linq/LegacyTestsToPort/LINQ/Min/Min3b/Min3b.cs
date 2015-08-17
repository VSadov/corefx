using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long, source has only one element
        public static int Test3b()
        {
            long[] source = { (long)Int32.MaxValue + 10 };
            long expected = (long)Int32.MaxValue + 10;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3b();
        }
    }
}
