using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-5: Test to verify that ApplyResultSelector function resizes the grouping to remove empty elements
        // DDB: 58085
        public static int Test7e()
        {
            char[] elements = { 'q', 'q', 'q', 'q', 'q' };

            var result = elements.GroupBy((e) => (e), (e, f) => new { Key = e, Element = f });

            foreach (var e in result)
            {
                if (e.Element.Count() != 5) return 1;
                if (e.Key != 'q') return 1;
                foreach (var ele in e.Element)
                    if (ele != 'q') return 1;
            }

            return 0;
        }


        public static int Main()
        {
            return Test7e();
        }
    }
}
