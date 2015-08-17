using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // first has one element more than second
        public static int Test9()
        {
            int?[] first = { 1, 2, 3, 4, 4 };
            int?[] second = { 1, 2, 3, 4 };
            bool expected = false;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
