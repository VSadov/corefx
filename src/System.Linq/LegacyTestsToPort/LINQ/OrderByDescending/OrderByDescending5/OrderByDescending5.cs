using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-2: 1st and last elements have same key and duplicate elements.
        // Verify the given comparer function is called. Also verifies order is preserved
        // This test calls AllequalCompaer with a EqualityComparer which is casInsensitive. This change is to help PLINQ team run our tests
        public static int Test5()
        {
            string[] source = { "Prakash", "Alpha", "DAN", "dan", "Prakash" };
            string[] expected = { "Prakash", "Prakash", "DAN", "dan", "Alpha" };

            var actual = source.OrderByDescending((e) => e, new CaseInsensitiveComparer());

            return Verification.AllequalComparer(expected, actual, new CaseInsensitiveEqualityComparer());
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
