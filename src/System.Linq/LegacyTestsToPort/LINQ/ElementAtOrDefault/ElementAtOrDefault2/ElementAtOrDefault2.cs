using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAtOrDefault
{
    public class Test
    {
        // source is of type IList, index = Number of elements in source;
        public static int Test2()
        {
            int[] source = {1, 2, 3, 4};
            int index = 4;
            int expected = default(int);

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            var actual = source.ElementAtOrDefault(index);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
