using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LongCount
{
    public class Test
    {
        // source is empty
        public static int Test1a()
        {
            int[] data = {};
            int expected = 0;

            var actual = data.LongCount();
            return ((expected==actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
