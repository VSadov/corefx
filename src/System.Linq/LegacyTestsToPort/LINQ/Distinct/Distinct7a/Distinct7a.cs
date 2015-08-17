using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is null
        public static int Test7a()
        {
            string[] source = { "Bob", "Tim", "bBo", "miT", "Robert", "iTm" };
            string[] expected = { "Bob", "Tim", "bBo", "miT", "Robert", "iTm" };

            var actual = source.Distinct(null);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7a();
        }
    }
}
