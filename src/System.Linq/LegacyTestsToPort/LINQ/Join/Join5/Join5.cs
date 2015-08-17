using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // innerKeySelector, outerKeySelector and resultSelector returns null
        public static int Test5()
        {
            int?[] inner = { null, null, null };
            int?[] outer = { null, null };

            int?[] expected = { };

            var actual = outer.Join(inner, (e) => e, (o) => o, (e1, e2) => (e1));

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
