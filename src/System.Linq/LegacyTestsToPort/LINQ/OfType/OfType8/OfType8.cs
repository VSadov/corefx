using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OfType
{
    public class Test
    {
        //  source is an string and type is decimal?
        public static int Test8()
        {
            string[] source = { "Test1", "Test2", "Test9" };
            decimal?[] expected = { };

            IEnumerable<decimal?> actual = source.OfType<decimal?>();

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
