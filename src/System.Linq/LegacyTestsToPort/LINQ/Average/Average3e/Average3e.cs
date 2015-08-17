using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long, selector function is called
        public static int Test3e()
        {
            Data_long[] source = new Data_long[]{ new Data_long{name="Tim", num=40L},
                                                  new Data_long{name="John", num=50L},
                                                  new Data_long{name="Bob", num=60L}
            };
            double expected = 50;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3e();
        }
    }
}
