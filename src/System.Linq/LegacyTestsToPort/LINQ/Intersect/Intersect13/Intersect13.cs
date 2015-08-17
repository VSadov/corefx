using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Intersect
{
    public class Test
    {
        // DDB:171937
        public static int Test13()
        {
            string[] first = { null, null, string.Empty };
            string[] second = { null, null };
            string[] expected = { null };

            var actual = first.Intersect(second, EqualityComparer<string>.Default);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test13();
        }
    }
}
