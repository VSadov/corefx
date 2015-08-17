using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToArray
{
    public class Test
    {
        // source is of type ICollection and source is empty
        public static int Test1()
        {
            int[] source = {};
            int[] expected = {};

            ICollection<int> collection = source as ICollection<int>;
            if (collection==null) return 1;

            var actual = source.ToArray();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
