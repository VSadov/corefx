using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ThenBy
{
    public class Test
    {
        // Overload-2: secondary keys repeat across elements with different primary keys
        public static int Test4()
        {
            Record[] source = new Record[]{
                               new Record{Name = "Jim", City = "Minneapolis", Country = "USA"},
                               new Record{Name = "Tim", City = "Seattle", Country = "USA"},
                               new Record{Name = "Philip", City = "Orlando", Country = "USA"},
                               new Record{Name = "Chris", City = "Minneapolis", Country = "USA"},
                               new Record{Name = "Rob", City = "Seattle", Country = "USA"}
            };
            Record[] expected = new Record[]{
                                 new Record{Name = "Chris", City = "Minneapolis", Country = "USA"},
                                 new Record{Name = "Jim", City = "Minneapolis", Country = "USA"},
                                 new Record{Name = "Philip", City = "Orlando", Country = "USA"},
                                 new Record{Name = "Rob", City = "Seattle", Country = "USA"},
                                 new Record{Name = "Tim", City = "Seattle", Country = "USA"}
            };

            var actual = source.OrderBy((e)=>e.Name).ThenBy((e)=>e.City, null);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test4();
        }
    }
}
