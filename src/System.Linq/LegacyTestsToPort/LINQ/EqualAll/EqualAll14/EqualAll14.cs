using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EqualAll
{
    public class Test
    {
        // DDB:171937
        public static int Test14()
        {
            string[] first = { null };
            string[] second = { null };
            bool expected = true;

            var actual = first.SequenceEqual(second, StringComparer.Ordinal);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test14();
        }
    }
}
