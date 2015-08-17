using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // DDB:171937
        public static int Test14()
        {
            string[] first = { null, null };
            string[] second = new string[0];
            string[] expected = new string[0];

            var actual = first.Intersect(second, EqualityComparer<string>.Default);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test14();
        }
    }
}
