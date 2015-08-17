using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // last element cannot be cast to type int: Test for InvalidCastException
        public static int Test3()
        {
            Object[] source = { -5, 9, 0, 5, 9, "Test" };
            int[] expected = { -5, 9, 0, 5, 9, 10 };

            try
            {
                IEnumerable<int> actual = source.Cast<int>();
                Verification.Allequal(expected, actual);
                return 1;
            }
            catch (InvalidCastException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
