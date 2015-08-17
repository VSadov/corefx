using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToList
{
    public class Test
    {
        // source is NOT of type ICollection and source has null elements only
        public static int Test5()
        {
            IEnumerable<int?> source = Functions.NullSeq(5);
            int?[] expected = {null, null, null, null, null};

            ICollection<int?> collection = source as ICollection<int?>;
            if (collection!=null) return 1;

            List<int?> actual = source.ToList();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
