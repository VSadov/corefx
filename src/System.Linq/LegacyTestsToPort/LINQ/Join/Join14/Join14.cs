using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Join
{
    public class Test
    {
        // DDB:171937
        public static int Test14()
        {
            string[] outer = new string[] { null, string.Empty };
            string[] inner = new string[] { null, string.Empty };
            string[] expected = new string[] { string.Empty };

            Func<string, string, string> resultSelector = (string x, string y) => y;

            var actual = outer.Join(inner, (e) => e, (o) => o, resultSelector, EqualityComparer<string>.Default).ToList();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test14();
        }
    }
}
