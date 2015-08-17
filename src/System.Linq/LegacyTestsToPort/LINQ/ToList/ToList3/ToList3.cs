using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToList
{
    public class Test
    {
        // source is NOT of type ICollection and source is empty
        public static int Test3()
        {
            IEnumerable<int> source = Functions.NumList(-4, 0);
            int[] expected = {};

            ICollection<int> collection = source as ICollection<int>;
            if (collection!=null) return 1;

            List<int> actual = source.ToList();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
