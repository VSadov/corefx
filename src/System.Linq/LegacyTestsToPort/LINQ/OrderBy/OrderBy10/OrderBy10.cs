using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderBy
{
    public class Test
    {
        // Overload-2: Test to verify that the QuickSort function handles underflow OutOfBounds Exception
        // DDB: 48535
        public static int Test10()
        {
            int[] source = { 1 };
            int[] expected = { 1 };

            var actual = source.OrderBy((e) => e, new BadComparer2());

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test10();
        }
    }
}
