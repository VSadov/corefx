using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: string, source is empty, default(T) is null
        public static int Test9i()
        {
            string[] source = { };
            string expected = default(string);

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9i();
        }
    }
}
