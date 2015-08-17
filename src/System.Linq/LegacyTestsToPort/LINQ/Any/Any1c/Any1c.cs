using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Any
{
    public class Test
    {
        // Overload without predicate, source has limited elements
        public static int Test1c()
        {
            int?[] source = {null, null, null, null};
            bool expected = true;

            var actual = source.Any();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
