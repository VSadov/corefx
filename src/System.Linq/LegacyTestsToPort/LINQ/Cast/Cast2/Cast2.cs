using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // first element cannot be cast to type int: Test for InvalidCastException
        public static int Test2()
        {
            Object[] source = { "Test", 3, 5, 10 };
            int[] expected = { 3, 5, 10 };

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
            return Test2();
        }
    }
}
