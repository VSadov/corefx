using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: int, Minimum occurs as the first element
        public static int Test2d()
        {
            int?[] source = { 6, null, 9, 10, null, 7, 8 };
            int? expected = 6;

            var actual = source.Min();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2d();
        }
    }
}
