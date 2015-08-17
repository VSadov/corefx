using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: Test for index=max source size-1
        public static int Test2j()
        {
            int[] source = {-40, 20, 100, 5, 4, 9};
            int[] expected = {9};
            Func<int, int, bool> predicate = (num, index)=>(index==5);

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2j();
        }
    }
}
