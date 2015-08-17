using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToList
{
    public class Test
    {
        // source is of type ICollection and source has few elements
        public static int Test2()
        {
            int?[] source = {-5, null, 0, 10, 3, -1, null, 4, 9};
            int?[] expected = {-5, null, 0, 10, 3, -1, null, 4, 9};

            ICollection<int?> collection = source as ICollection<int?>;
            if (collection==null) return 1;

            List<int?> actual = source.ToList();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
