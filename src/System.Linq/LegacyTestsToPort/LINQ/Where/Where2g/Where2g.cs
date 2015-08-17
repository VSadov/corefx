using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: predicate returns true for 1st, 3rd and 6th
        public static int Test2g()
        {
            int[] source = {20, 7, 18, 9, 7, 10, 21};
            int[] expected = {20, 18, 10};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2g();
        }
    }
}
