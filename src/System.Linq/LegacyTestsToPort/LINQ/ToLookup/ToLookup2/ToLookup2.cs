using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToLookup
{
    public class Test
    {
        // Overload-2: Only one element is present and given Comparer is used.
        public static int Test2()
        {
            string[] key = { "Chris" };
            int[] element = { 50 };
            Record[] source = new Record[1];

            // key is an anagram of Chris
            source[0].Name = "risCh"; source[0].Score = element[0];

            var result = source.ToLookup((e) => e.Name, new AnagramEqualityComparer());

            return Helper.MatchAll(key, source, result);
        }


        public static int Main()
        {
            return Test2();
        }
    }
}
