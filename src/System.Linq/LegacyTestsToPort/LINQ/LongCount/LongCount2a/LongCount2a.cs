using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LongCount
{
    public class Test
    {
        // source has only one element
        public static int Test2a()
        {
            int[] data = {3};
            int expected = 1;

            var actual = data.LongCount();
            return ((expected==actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
