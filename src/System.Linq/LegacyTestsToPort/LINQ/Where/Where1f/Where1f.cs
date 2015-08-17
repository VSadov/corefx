using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-1: predicate returns true for last element only
        public static int Test1f()
        {
            int[] source = {9, 7, 15, 3, 27, 20};
            int[] expected = {20};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1f();
        }
    }
}
