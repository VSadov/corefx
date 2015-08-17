using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cast
{
    public class Test
    {
        // source of type object Cast to type string
        // DDB: 137558
        public static int Test17()
        {
            object[] source = { "Test1",  "4.5", null, "Test2" };
            string[] expected = { "Test1", "4.5", null, "Test2" };

            IEnumerable<string> actual = source.Cast<string>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test17();
        }
    }
}
