using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-4: source is empty
        public static int Test1()
        {
            string[] key = { };
            int[] element = { };
            Record[] source = new Record[] { };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score, new AnagramEqualityComparer());

            return Verification.MatchAll(key, element, result, new AnagramEqualityComparer());
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
