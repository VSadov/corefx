using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ThenBy
{
    public class Test
    {
        // Overload-1: secondary keys are unique
        public static int Test2()
        {
            Record[] source = new Record[]{
                               new Record{Name = "Jim", City = "Minneapolis", Country = "USA"},
                               new Record{Name = "Tim", City = "Seattle", Country = "USA"},
                               new Record{Name = "Philip", City = "Orlando", Country = "USA"},
                               new Record{Name = "Chris", City = "London", Country = "UK"},
                               new Record{Name = "Rob", City = "Kent", Country = "UK"}
            };
            Record[] expected = new Record[]{
                                 new Record{Name = "Rob", City = "Kent", Country = "UK"},
                                 new Record{Name = "Chris", City = "London", Country = "UK"},
                                 new Record{Name = "Jim", City = "Minneapolis", Country = "USA"},
                                 new Record{Name = "Philip", City = "Orlando", Country = "USA"},
                                 new Record{Name = "Tim", City = "Seattle", Country = "USA"}
            };

            var actual = source.OrderBy((e)=>e.Country).ThenBy((e)=>e.City);

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test2();
        }
    }
}
