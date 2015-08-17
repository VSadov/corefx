using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: Test for index=0
        public static int Test2i()
        {
            int[] source = {-40, 20, 100, 5, 4, 9};
            int[] expected = {-40};
            Func<int, int, bool> predicate = (num, index)=>(index==0);

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2i();
        }
    }
}
