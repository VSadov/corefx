using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: string, source has all null values
        public static int Test9g()
        {
            string[] source = { null, null, null, null, null };
            string expected = null;

            var actual = source.Max();

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9g();
        }
    }
}
