using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // DDB:171937
        public static int Test012()
        {
            string[] key = { null };
            string[] element = { null };
            string[] source = new string[] { null };

            var result = source.GroupBy((e) => e, (e) => e, EqualityComparer<string>.Default);

            return Verification.MatchAll(key, element, result, EqualityComparer<string>.Default);
        }


        public static int Main()
        {
            return Test012();
        }
    }
}
