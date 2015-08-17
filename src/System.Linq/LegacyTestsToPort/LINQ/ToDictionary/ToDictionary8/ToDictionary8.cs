using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    public class Test
    {
        // Overload-2: source has limited number of elements.
        // elementSelector is not specified and comparer is not null.
        // 1st element in source is an anagram of key[0] to verify the comparer 
        // functions is called.
        public static int Test8()
        {
            string[] key = new string[]{"Bob", "Zen", "Prakash", "Chris", "Sachin"};
            Record[] source =  new Record[]{new Record{Name="Bbo", Score=95}, new Record{Name=key[1], Score=45},
                                new Record{Name=key[2], Score=100}, new Record{Name=key[3], Score=90},
                                new Record{Name=key[4], Score=45}};

            var result = source.ToDictionary((e)=>e.Name, new AnagramEqualityComparer());

            return Helper.MatchAll(key, source, result);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
