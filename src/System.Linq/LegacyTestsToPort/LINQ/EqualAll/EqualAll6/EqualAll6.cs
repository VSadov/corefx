using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // first elements do not match
        public static int Test6()
        {
            int?[] first = { 1, 2, 3, 4, 5 };
            int?[] second = { 2, 2, 3, 4, 5 };
            bool expected = false;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
