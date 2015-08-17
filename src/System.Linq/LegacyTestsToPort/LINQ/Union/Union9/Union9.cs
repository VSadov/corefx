using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is null
        public static int Test9()
        {
            string[] first = { "Bob", "Robert", "Tim", "Matt", "miT" };
            string[] second = { "ttaM", "Charlie", "Bbo" };
            string[] expected = { "Bob", "Robert", "Tim", "Matt", "miT", "ttaM", "Charlie", "Bbo" };

            var actual = first.Union(second, null);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
