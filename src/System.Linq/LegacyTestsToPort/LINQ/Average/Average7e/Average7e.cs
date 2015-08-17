using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal, selector function is called
        public static int Test7e()
        {
            Data_decimal[] source = new Data_decimal[]{ new Data_decimal{name="Tim", num=5.5m},
                                                        new Data_decimal{name="John", num=15.5m},
                                                        new Data_decimal{name="Bob", num=3.0m}
            };
            decimal expected = 8.0m;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7e();
        }
    }
}
