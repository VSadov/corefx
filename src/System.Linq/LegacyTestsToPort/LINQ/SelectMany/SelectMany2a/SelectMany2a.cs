using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public class Test
    {
        // Overload-2: source is empty
        public static int Test2a()
        {
            CustomerRec[] source = { };
            int?[] expected = { };
            Func<CustomerRec, int, IEnumerable<int?>> selector = (e, index) => e.total;

            var actual = source.SelectMany(selector);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test2a();
        }
    }
}
