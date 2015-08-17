using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LastOrDefault
{
    public class Test
    {
        // source is of type IList, source has > 1 element
        public static int Test1c()
        {
            int?[] source = {-10, 2, 4, 3, 0, 2, null};
            int? expected = null; 

            IList<int?> list = source as IList<int?>;

            if (list == null) return 1;

            var actual = source.LastOrDefault();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1c();
        }
    }
}
