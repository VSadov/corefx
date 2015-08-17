using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // first and second has only one element
        public static int Test5()
        {
            int?[] first = { 2 };
            int?[] second = { 4 };
            bool expected = false;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
