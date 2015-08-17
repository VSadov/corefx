using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    public class Test
    {
        // DDB:171937
        public static int Test9()
        {
            string[] element = new string[] { null };
            string[] key = new string[] { string.Empty };
            string[] source =  new string[]{ null };

            // The key of a Dictionary can not be null, so add ??. This case can pass before DDB:171937 bug fixing.
            Dictionary<string, string> result = source.ToDictionary((e)=>e??string.Empty, (e)=>e, EqualityComparer<string>.Default);

            return Helper.MatchAll<string, string>(key, element, result);
        }


        public static int Main()
        {
            return Test9();
        }
    }
}
