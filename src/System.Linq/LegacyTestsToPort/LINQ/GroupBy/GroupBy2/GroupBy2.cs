using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-1: source has only one element
        public static int Test2()
        {
            string[] key = { "Tim" };
            int[] element = { 60 };
            Record[] source = new Record[] { new Record { Name = key[0], Score = element[0] } };

            var result = source.GroupBy((e) => e.Name);

            return Verification.MatchAll(key, source, result);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
