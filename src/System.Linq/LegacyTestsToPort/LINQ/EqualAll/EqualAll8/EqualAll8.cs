using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // second has one element more than first
        public static int Test8()
        {
            int?[] first = { 1, 2, 3, 4 };
            int?[] second = { 1, 2, 3, 4, 4 };
            bool expected = false;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
