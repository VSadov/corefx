using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: source has null and predicate returns true
        public static int Test2h()
        {
            int?[] source = {null, null, null, null};
            int?[] expected = {null, null, null, null};
            Func<int?, int, bool> predicate = (num, index)=>true;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2h();
        }
    }
}
