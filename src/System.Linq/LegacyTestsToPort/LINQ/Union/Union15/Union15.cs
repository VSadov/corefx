using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Union
{
    public class Test
    {
        // DDB:171937
        public static int Test13()
        {
            string[] first = { null, null };
            string[] second = new string[0];
            string[] expected = { null };

            var actual = first.Union(second, EqualityComparer<string>.Default);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test13();
        }
    }
}
