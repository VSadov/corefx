using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: decimal?, selector function is called
        public static int Test8g()
        {
            Data_Ndecimal[] source = new Data_Ndecimal[]{ new Data_Ndecimal{name="Tim", num=20.51m},
                                                new Data_Ndecimal{name="John", num=null},
                                                new Data_Ndecimal{name="Bob", num=2.33m}
            };
            decimal? expected = 22.84m;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8g();
        }
    }
}
