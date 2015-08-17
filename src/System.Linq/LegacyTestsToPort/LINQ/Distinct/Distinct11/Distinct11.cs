using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Distinct
{
    public class Test
    {
        // DDB:171937
        public static int Test11()
        {
            string[] source = { null, null, string.Empty };
            string[] expected = { null, string.Empty };

            var actual = source.Distinct(EqualityComparer<string>.Default);
            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test11();
        }
    }
}
