using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is null
        public static int Test8()
        {
            string[] first = { "Tim", "Bob", "Mike", "Robert" };
            string[] second = { "ekiM", "bBo" };
            string[] expected = { };

            var actual = first.Intersect(second, null);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
