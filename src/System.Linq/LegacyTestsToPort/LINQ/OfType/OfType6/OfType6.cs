using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        //  source is an int and type is int?
        public static int Test6()
        {
            int[] source = { -4, 4, 9 };
            int?[] expected = { -4, 4, 9 };

            IEnumerable<int?> actual = source.OfType<int?>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
