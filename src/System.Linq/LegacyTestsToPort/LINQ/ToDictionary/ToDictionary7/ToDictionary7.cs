using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    public class Test
    {
        // Overload-4: source has one element and comparer is null
        public static int Test7()
        {
            int[] element = new int[]{5};
            string[] key = new string[]{"Bob"};
            Record[] source =  new Record[]{new Record{Name=key[0], Score=element[0]}};

            var result = source.ToDictionary((e)=>e.Name, (e)=>e.Score, null);

            return Helper.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
