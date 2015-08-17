using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal, selector function is called
        public static int Test7g()
        {
            Data_decimal[] source = new Data_decimal[]{ new Data_decimal{name="Tim", num=420.5m},
                                                new Data_decimal{name="John", num=900.25m},
                                                new Data_decimal{name="Bob", num=10.45m}
            };
            decimal expected = 900.25m;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7g();
        }
    }
}
