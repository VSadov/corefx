using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: decimal, selector function is called
        public static int Test8g()
        {
            Data_Ndecimal[] source = new Data_Ndecimal[]{ new Data_Ndecimal{name="Tim", num=5.5m},
                                                          new Data_Ndecimal{name="John", num=15.5m},
                                                          new Data_Ndecimal{name="Bob", num=null}
            };
            decimal? expected = 10.5m;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8g();
        }
    }
}
