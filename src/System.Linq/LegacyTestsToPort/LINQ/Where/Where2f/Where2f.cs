using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: predicate returns true for last element only
        public static int Test2f()
        {
            int[] source = {9, 7, 15, 3, 27, 20};
            int[] expected = {20};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2f();
        }
    }
}
