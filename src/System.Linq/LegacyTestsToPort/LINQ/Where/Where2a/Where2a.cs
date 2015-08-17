using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Where
{
    public class Test
    {
        // Overload-2: source is empty
        public static int Test2a()
        {
            int[] source = {};
            int[] expected = {};
            Func<int, int, bool> predicate = Functions.IsEven_Index;

            var actual = source.Where(predicate);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
