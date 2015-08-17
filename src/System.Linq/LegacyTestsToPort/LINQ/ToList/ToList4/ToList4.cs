using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToList
{
    public class Test
    {
        // source is NOT of type ICollection and source has few elements
        public static int Test4()
        {
            IEnumerable<int> source = Functions.NumList(-4, 10);
            int[] expected = {-4, -3, -2, -1, 0, 1, 2, 3, 4, 5};

            ICollection<int> collection = source as ICollection<int>;
            if (collection!=null) return 1;

            List<int> actual = source.ToList();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
