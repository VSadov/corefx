using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-1: predicate returns true for 1st, 3rd and 6th
        public static int Test1g()
        {
            int[] source = {20, 7, 18, 9, 7, 10, 21};
            int[] expected = {20, 18, 10};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1g();
        }
    }
}
