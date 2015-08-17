using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // first is non-empty and second is empty
        public static int Test4()
        {
            int?[] first = { 2, 3, 4 };
            int?[] second = { };
            bool expected = false;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
