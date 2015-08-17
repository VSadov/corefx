using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type int? Cast to type long?
        // DDB: 137558
        public static int Test9()
        {
            try
            {
                int?[] source = new int?[] { -4, 1, 2, 3, 9, null };
                long?[] expected = { -4L, 1L, 2L, 3L, 9L, null };

                IEnumerable<long?> actual = source.Cast<long?>();
		Verification.Allequal(expected,actual);
            }
            catch (InvalidCastException)
            {
                return 0;
            }
            catch (Exception) { return 1; }
            return 1;
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
