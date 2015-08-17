using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: decimal, selector function is called
        public static int Test7g()
        {
            Data_decimal[] source = new Data_decimal[]{ new Data_decimal{name="Tim", num=100.45m},
                                                new Data_decimal{name="John", num=10.5m},
                                                new Data_decimal{name="Bob", num=0.05m}
            };
            decimal expected = 0.05m;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test7g();
        }
    }
}
