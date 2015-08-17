using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkipWhile
{
    public class Test
    {
        // Number of elements in source>0 and predicate returns true for all
        // (Predicate without index)
        public static int Test1a()
        {
            int[] source = {6, 8, 10, 12, 4};
            int[] expected = {};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.SkipWhile(predicate);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
