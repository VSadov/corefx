using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // first is empty and second is non-empty
        public static int Test3()
        {
            int?[] first = { };
            int?[] second = { 2, 3, 4 };
            bool expected = false;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
