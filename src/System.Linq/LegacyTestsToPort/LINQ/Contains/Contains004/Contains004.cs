using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // DDB:171937
        public static int Test004()
        {

            string[] source = { null };
            string value = null;
            bool expected = true;

            // Check whether source is actually ICollection
            ICollection<string> collection = source as ICollection<string>;
            if (collection == null) return 1;

            var actual = source.Contains(value, StringComparer.Ordinal);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test004();
        }
    }
}
