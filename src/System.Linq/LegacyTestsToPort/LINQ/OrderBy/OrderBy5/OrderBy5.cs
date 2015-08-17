using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderBy
{
    public class Test
    {
        // Overload-2: 1st and last elements have same key and duplicate elements.
        // Verify the given comparer function is called.
        // This test calls AllequalCompaer with a EqualityComparer which is casInsensitive. This change is to help PLINQ team run our tests
        public static int Test5()
        {
            string[] source = { "Prakash", "Alpha", "dan", "DAN", "Prakash" };
            string[] expected = { "Alpha", "dan", "DAN", "Prakash", "Prakash" };

            var actual = source.OrderBy((e) => e, new CaseInsensitiveComparer());

            return Verification.AllequalComparer(expected, actual, new CaseInsensitiveEqualityComparer());
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
