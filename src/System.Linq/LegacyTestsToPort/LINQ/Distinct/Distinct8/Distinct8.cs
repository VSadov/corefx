using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is not-null
        // This test case calls the AllequalComparer to verify that the expected matches the result
        // This will help the PLINQ team when they run the test, since both "Tim", "miT", "iTm" are all the same and should not matter
        public static int Test8()
        {
            string[] source = { "Bob", "Tim", "bBo", "miT", "Robert", "iTm" };
            string[] expected = { "Bob", "Tim", "Robert" };

            var actual = source.Distinct(new AnagramEqualityComparer());
            return Verification.AllequalComparer(expected, actual, new AnagramEqualityComparer());
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
