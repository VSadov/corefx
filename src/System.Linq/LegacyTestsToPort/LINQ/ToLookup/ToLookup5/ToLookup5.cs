using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToLookup
{
    public class Test
    {
        //Overload-4: source is empty
        public static int Test5()
        {
            string[] key = { };
            int[] element = { };
            Record[] source = new Record[] { };

            System.Linq.ILookup<string, int> result = source.ToLookup((e) => e.Name, (e) => e.Score, new AnagramEqualityComparer());

            return Helper.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
