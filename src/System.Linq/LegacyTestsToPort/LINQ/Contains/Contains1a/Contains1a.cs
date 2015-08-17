using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // source implements ICollection, source is empty
        public static int Test1a()
        {
            int[] source = { };
            int value = 6;
            bool expected = false;

            // Check whether source is actually ICollection
            ICollection<int> collection = source as ICollection<int>;
            if (collection == null) return 1;

            var actual = source.Contains(value);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1a();
        }
    }
}
