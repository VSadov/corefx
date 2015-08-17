using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Contains
{
    public class Test
    {
        // Overload-2: Test when EqualityComparer is not null
        public static int Test1i()
        {
            string[] source = { "Bob", "Robert", "Tim" };
            string value = "trboeR";
            bool expected = true;

            // Check whether source is actually ICollection
            ICollection<string> collection = source as ICollection<string>;
            if (collection == null) return 1;

            var actual = source.Contains(value, new AnagramEqualityComparer());

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test1i();
        }
    }
}
