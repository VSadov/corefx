using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Except
{
    public class Test
    {
        // DDB:171937
        public static int Test12()
        {
            string[] first = { null, null, string.Empty };
            string[] second = { null };
            string[] expected = { string.Empty };

            var actual = first.Except(second, EqualityComparer<string>.Default);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test12();
        }
    }
}
