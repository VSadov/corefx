using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-8: source is empty
        public static int Test10e()
        {
            string[] key = { };
            int[] element = { };
            Record[] source = new Record[] { };
            Func<string, IEnumerable<int>, long> res2 = Helper.resultSelect2;
            long[] expected = { };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score, res2, new AnagramEqualityComparer());

            return Verification.Allequal(expected, result);
        }


        public static int Main()
        {
            return Test10e();
        }
    }
}
