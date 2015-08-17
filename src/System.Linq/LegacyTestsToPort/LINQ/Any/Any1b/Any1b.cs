using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Any
{
    public class Test
    {
        // Overload without predicate, source has one element
        public static int Test1b()
        {
            int[] source = {3};
            bool expected = true;

            var actual = source.Any();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1b();
        }
    }
}
