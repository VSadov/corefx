using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupJoin
{
    public class Test
    {
        // DDB:171937
        public static int Test12()
        {
            string[] outer = new string[] { null };
            string[] inner = new string[] { null };
            string[] expected = new string[] { null };

            Func<string, IEnumerable<string>, string> resultSelector = (string x, IEnumerable<string> y) => x;

            var actual = outer.GroupJoin(inner, (e) => e, (o) => o, resultSelector, EqualityComparer<string>.Default);

            return Verification.Allequal(expected, actual);
        }

        public static int Main()
        {
            return Test12();
        }
    }
}
