using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToLookup
{
    public class Test
    {
        // Overload-3: All elements are unique and elementSelector function is called.
        public static int Test3()
        {
            string[] key = { "Chris", "Prakash", "Tim", "Robert", "Brian" };
            int[] element = { 50, 100, 95, 60, 80 };
            Record[] source = new Record[5];

            source[0].Name = key[0]; source[0].Score = element[0];
            source[1].Name = key[1]; source[1].Score = element[1];
            source[2].Name = key[2]; source[2].Score = element[2];
            source[3].Name = key[3]; source[3].Score = element[3];
            source[4].Name = key[4]; source[4].Score = element[4];

            var result = source.ToLookup((e) => e.Name, (e) => e.Score);

            return Helper.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test3();
        }
    }
}
