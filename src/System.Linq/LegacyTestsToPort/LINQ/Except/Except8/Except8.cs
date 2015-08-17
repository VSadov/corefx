using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // Overload-2: Test for EqualityComparer is not-null
        public static int Test8()
        {
            string[] first = { "Bob", "Tim", "Robert", "Chris" };
            string[] second = { "bBo", "shriC" };
            string[] expected = { "Tim", "Robert" };

            var actual = first.Except(second, new AnagramEqualityComparer());
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
