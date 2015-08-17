using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // value is null and source does not has null
        public static int Test1f()
        {
            int?[] source = { 8, 0, 10, 3, 0, -8, 0 };
            int? value = null;
            bool expected = false;

            // Check whether source is actually ICollection
            ICollection<int?> collection = source as ICollection<int?>;
            if (collection == null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1f();
        }
    }
}
