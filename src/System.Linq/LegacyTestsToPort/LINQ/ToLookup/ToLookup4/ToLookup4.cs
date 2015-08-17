using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToLookup
{
    public class Test
    {
        // Overload-4: keySelector has duplicate values
        public static int Test4()
        {
            string[] key = { "Chris", "Prakash", "Robert" };
            int[] element = { 50, 80, 100, 95, 99, 56 };
            Record[] source = new Record[6];

            source[0].Name = key[0]; source[0].Score = element[0];
            source[1].Name = key[1]; source[1].Score = element[2];
            source[2].Name = key[2]; source[2].Score = element[5];
            source[3].Name = key[1]; source[3].Score = element[3];
            source[4].Name = key[0]; source[4].Score = element[1];
            source[5].Name = key[1]; source[5].Score = element[4];

            System.Linq.ILookup<string, int> result = source.ToLookup((e) => e.Name, (e) => e.Score, new AnagramEqualityComparer());

            return Helper.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test4();
        }
    }
}
