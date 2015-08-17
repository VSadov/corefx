using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: int, source has only one element
        public static int Test1b()
        {
            int[] source = { 5 };
            double expected = 5;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
