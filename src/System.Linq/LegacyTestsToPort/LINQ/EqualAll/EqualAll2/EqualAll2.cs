using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // Corresponding elements in first and second are same
        public static int Test2()
        {
            int?[] first = { -6, null, 0, -4, 9, 10, 20 };
            int?[] second = { -6, null, 0, -4, 9, 10, 20 };
            bool expected = true;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
