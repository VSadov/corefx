using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-2: 1st and last elements have same key and duplicate elements.
        // Verify default comparer is called.
        public static int Test6()
        {
            string[] source = { "Prakash", "Alpha", "DAN", "dan", "Prakash" };
            string[] expected = { "Prakash", "Prakash", "DAN", "dan", "Alpha" };

            var actual = source.OrderByDescending((e) => e, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
