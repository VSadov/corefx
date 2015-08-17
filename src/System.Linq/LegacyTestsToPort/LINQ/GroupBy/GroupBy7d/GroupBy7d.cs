using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-5: source has only one element
        public static int Test7d()
        {
            string[] key = { "Tim" };
            int[] element = { 60 };
            Record[] source = new Record[] { new Record { Name = key[0], Score = element[0] } };
            Func<string, IEnumerable<Record>, long> res1 = Helper.resultSelect1;
            long[] expected = { 180 };

            var result = source.GroupBy((e) => e.Name, res1);

            return Verification.Allequal(expected, result);
        }


        public static int Main()
        {
            return Test7d();
        }
    }
}
