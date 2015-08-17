using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    public class Test
    {
        // Overload-4: source is empty
        public static int Test6()
        {
            int[] element = new int[]{};
            string[] key = new string[]{};
            Record[] source =  new Record[]{};

            Dictionary<string, int>result = source.ToDictionary((e)=>e.Name, (e)=>e.Score, new AnagramEqualityComparer());

            return Helper.MatchAll<string, int>(key, element, result);
        }


        public static int Main()
        {
            return Test6();
        }
    }
}
