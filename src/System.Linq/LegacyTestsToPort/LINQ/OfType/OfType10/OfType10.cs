using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        //  source is an int and type is long
        public static int Test10()
        {
            int[] source = { 99, 45, 81 };
            long[] expected = {  };

            IEnumerable<long> actual = source.OfType<long>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
