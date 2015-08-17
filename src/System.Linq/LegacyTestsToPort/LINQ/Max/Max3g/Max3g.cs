using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, selector function is called
        public static int Test3g()
        {
            Data_long[] source = new Data_long[]{ new Data_long{name="Tim", num=10L},
                                                new Data_long{name="John", num=-105L},
                                                new Data_long{name="Bob", num=Int64.MaxValue}
            };
            long expected = Int64.MaxValue;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3g();
        }
    }
}
