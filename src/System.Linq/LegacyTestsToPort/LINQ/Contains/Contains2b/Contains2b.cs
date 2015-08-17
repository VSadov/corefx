using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // value does not occur in source
        public static int Test2b()
        {
            IEnumerable<int> source = Functions.NumList(4, 5);
            int value = 3;
            bool expected = false;

            // Check whether source is actually ICollection
            ICollection<int> collection = source as ICollection<int>;
            if (collection != null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2b();
        }
    }
}
