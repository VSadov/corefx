using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: int, maximum value occurs as the last element
        public static int Test1e()
        {
            int[] source = { 6, 9, 10, 0, 50 };
            int expected = 50;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1e();
        }
    }
}
