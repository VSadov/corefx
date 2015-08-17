using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToLookup
{
    public class Test
    {
        // DDB:171937
        public static int Test7()
        {
            string[] key = { null };
            string[] element = { null };
            string[] source = new string[] { null };

            System.Linq.ILookup<string, string> result = source.ToLookup((e) => e, (e) => e, EqualityComparer<string>.Default);

            return Helper.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test7();
        }
    }
}
