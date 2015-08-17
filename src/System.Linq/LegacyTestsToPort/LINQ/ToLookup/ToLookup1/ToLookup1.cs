using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToLookup
{
    public class Test
    {
        // Overload-1: keySelector returns null.
        public static int Test1()
        {
            string[] key = { "Chris", "Bob", null, "Tim" };
            int[] element = { 50, 95, 55, 90 };
            Record[] source = new Record[4];

            source[0].Name = key[0]; source[0].Score = element[0];
            source[1].Name = key[1]; source[1].Score = element[1];
            source[2].Name = key[2]; source[2].Score = element[2];
            source[3].Name = key[3]; source[3].Score = element[3];

            var result = source.ToLookup((e) => e.Name);

            return Helper.MatchAll(key, source, result);
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
