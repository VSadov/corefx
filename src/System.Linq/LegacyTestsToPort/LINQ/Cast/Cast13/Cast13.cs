using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type object cast to IEnumerable<int> 
        // DDB: 137558
        public static int Test13()
        {
            Object[] source = { -4, 1, 2, 3, 9, "45" };
            int[] expected = { -4, 1, 2, 3, 9, 45 };

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
            return Test13();
        }
    }
}
