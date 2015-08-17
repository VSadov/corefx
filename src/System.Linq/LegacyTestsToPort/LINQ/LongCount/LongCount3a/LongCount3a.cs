using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LongCount
{
    public class Test
    {
        // source has number of elements > 1
        public static int Test3a()
        {
            int?[] data = {-10, 4, 9 , null, 11};
            int expected = 5;

            var actual = data.LongCount();
            return ((expected==actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3a();
        }
    }
}
