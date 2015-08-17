using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // first is empty and second is empty
        public static int Test1()
        {
            int[] first = { };
            int[] second = { };
            bool expected = true;

            var actual = first.SequenceEqual(second);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
