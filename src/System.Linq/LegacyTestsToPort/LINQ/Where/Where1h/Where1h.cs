using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-1: source has null and predicate returns true
        public static int Test1h()
        {
            int?[] source = {null, null, null, null};
            int?[] expected = {null, null, null, null};
            Func<int?, bool> predicate = (num)=>true;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1h();
        }
    }
}
