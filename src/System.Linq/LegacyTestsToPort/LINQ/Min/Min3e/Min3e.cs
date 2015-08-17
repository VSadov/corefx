using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long, minimum value occurs as the last element
        public static int Test3e()
        {
            long[] source = { 6, 9, 10, 0, (long)-Int32.MaxValue - 50 };
            long expected = (long)-Int32.MaxValue - 50;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3e();
        }
    }
}
