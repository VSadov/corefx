using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: int, maximum value occurs as the first element
        public static int Test1d()
        {
            int[] source = { 16, 9, 10, 7, 8 };
            int expected = 16;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1d();
        }
    }
}
