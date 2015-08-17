using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal, selector function is called
        public static int Test7f()
        {
            Data_decimal[] source = new Data_decimal[]{ new Data_decimal{name="Tim", num=20.51m},
                                                new Data_decimal{name="John", num=10m},
                                                new Data_decimal{name="Bob", num=2.33m}
            };
            decimal expected = 32.84m;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7f();
        }
    }
}
