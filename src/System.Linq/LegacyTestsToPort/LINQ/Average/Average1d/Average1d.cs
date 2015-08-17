using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: int, source has different values
        public static int Test1d()
        {
            int[] source = { 5, -10, 15, 40, 28 };
            double expected = 15.6;

            var actual = source.Average();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1d();
        }
    }
}
