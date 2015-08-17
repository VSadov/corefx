using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ThenBy
{
    public class Test
    {
        // Overload-2: OrderBy and ThenBy on the same field
        public static int Test3()
        {
            Record[] source = new Record[]{
                               new Record{Name = "Jim", City = "Minneapolis", Country = "USA"},
                               new Record{Name = "Prakash", City = "Chennai", Country = "India"},
                               new Record{Name = "Rob", City = "Kent", Country = "UK"}
            };
            Record[] expected = new Record[]{
                                 new Record{Name = "Prakash", City = "Chennai", Country = "India"},
                                 new Record{Name = "Rob", City = "Kent", Country = "UK"},
                                 new Record{Name = "Jim", City = "Minneapolis", Country = "USA"}
            };

            var actual = source.OrderBy((e)=>e.Country).ThenBy((e)=>e.Country, null);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test3();
        }
    }
}
