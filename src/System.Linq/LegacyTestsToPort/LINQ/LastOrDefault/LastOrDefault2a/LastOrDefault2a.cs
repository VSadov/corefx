using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LastOrDefault
{
    public class Test
    {
        // source is empty
        public static int Test2a()
        {
            int?[] source = {};
            int? expected = null;

            var actual = source.LastOrDefault((x)=>true);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
