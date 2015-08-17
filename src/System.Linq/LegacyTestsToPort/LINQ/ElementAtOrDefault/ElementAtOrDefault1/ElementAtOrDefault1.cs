using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAtOrDefault
{
    public class Test
    {
        // source is of type IList, index < 0;
        public static int Test1()
        {
            int?[] source = {9, 8};
            int index = -1;
            int? expected = null;

            IList<int?> list = source as IList<int?>;

            if (list == null) return 1;

            var actual = source.ElementAtOrDefault(index);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
