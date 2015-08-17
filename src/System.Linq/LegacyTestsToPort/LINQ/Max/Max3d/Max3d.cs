using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, maximum value occurs as the first element
        public static int Test3d()
        {
            long[] source = { 250, 49, 130, 47, 28 };
            long expected = 250;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3d();
        }
    }
}
