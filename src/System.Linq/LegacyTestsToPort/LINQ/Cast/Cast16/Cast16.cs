using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // Cast involving Generic types
        // DDB: 137558
        public static int Test16()
        {
            try
            {
                long[] expected = { -1L, 0L, 9L, 10L };

                var x = Helper.GenericTest<long>(9L, expected);
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
            return Test16();
        }
    }
}
