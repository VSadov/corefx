using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LastOrDefault
{
    public class Test
    {
        // source is of type IList, source is empty
        public static int Test1a()
        {
            int[] source = {};
            int expected = default(int);

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            var actual = source.LastOrDefault();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
