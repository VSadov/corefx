using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        // source is empty
        public static int Test1()
        {
            Object[] source = { };
            int[] expected = { };

            IEnumerable<int> actual = source.OfType<int>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
