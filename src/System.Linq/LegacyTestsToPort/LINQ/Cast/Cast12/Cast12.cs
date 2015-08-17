using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type int? to object cast to IEnumerable<int?> 
        // DDB: 137558
        public static int Test12()
        {
            int? i = 10;
            Object[] source = { -4, 1, 2, 3, 9, null, i };
            int?[] expected = { -4, 1, 2, 3, 9, null, i };

            IEnumerable<int?> actual = source.Cast<int?>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test12();
        }
    }
}
