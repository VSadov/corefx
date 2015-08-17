using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // source does NOT implement ICollection, source is empty
        public static int Test2a()
        {
            IEnumerable<int> source = Functions.NumList(0, 0);
            int value = 0;
            bool expected = false;

            // Check whether source is actually ICollection
            ICollection<int> collection = source as ICollection<int>;
            if (collection != null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
