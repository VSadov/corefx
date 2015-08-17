using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Any
{
    public class Test
    {
        // Overload without predicate, source is empty
        public static int Test1a()
        {
            int[] source = {};
            bool expected = false;

            var actual = source.Any();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
