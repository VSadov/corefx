using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: long, selector function is called
        public static int Test3g()
        {
            Data_long[] source = new Data_long[]{ new Data_long{name="Tim", num=10L},
                                                new Data_long{name="John", num=Int64.MinValue},
                                                new Data_long{name="Bob", num=-10L}
            };
            long expected = Int64.MinValue;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3g();
        }
    }
}
