using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: long, selector function is called
        public static int Test3f()
        {
            Data_long[] source = new Data_long[]{ new Data_long{name="Tim", num=10L},
                                                new Data_long{name="John", num=Int32.MaxValue},
                                                new Data_long{name="Bob", num=40L}
            };
            long expected = (long)Int32.MaxValue + 50;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3f();
        }
    }
}
