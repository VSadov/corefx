using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is not-null
        public static int Test9()
        {
            string[] first = { "Tim", "Bob", "Mike", "Robert" };
            string[] second = { "ekiM", "bBo" };
            string[] expected = { "Bob", "Mike" };

            var actual = first.Intersect(second, new AnagramEqualityComparer());

            return Verification.AllequalComparer(expected, actual, new AnagramEqualityComparer());
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
