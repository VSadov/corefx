using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-1: source has only one element and predicate returns false
        public static int Test1c()
        {
            int[] source = {2};
            int[] expected = {2};
            Func<int, bool> predicate = Functions.IsEven;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
