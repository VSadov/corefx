using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is not-null
        // This test calls the AllequalComparer function to perform the verification
        // This will help the PLINQ team to run these tests, since "Tim", "miT" are the same when the approriate comparer is passed
        public static int Test10()
        {
            string[] first = { "Bob", "Robert", "Tim", "Matt", "miT" };
            string[] second = { "ttaM", "Charlie", "Bbo" };
            string[] expected = { "Bob", "Robert", "Tim", "Matt", "Charlie" };

            var actual = first.Union(second, new AnagramEqualityComparer());
            return Verification.AllequalComparer(expected, actual, new AnagramEqualityComparer());
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
