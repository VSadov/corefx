using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // value is null and source has null
        public static int Test2g()
        {
            IEnumerable<int?> source = Helper.NumList_Null(5);
            int? value = null;
            bool expected = true;

            // Check whether source is actually ICollection
            ICollection<int?> collection = source as ICollection<int?>;
            if (collection != null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2g();
        }
    }
}
