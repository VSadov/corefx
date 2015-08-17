using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // Overload-2: Test for EqualityComparer is null
        public static int Test7()
        {
            string[] first = { "Bob", "Tim", "Robert", "Chris" };
            string[] second = { "bBo", "shriC" };
            string[] expected = { "Bob", "Tim", "Robert", "Chris" };

            var actual = first.Except(second, null);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
