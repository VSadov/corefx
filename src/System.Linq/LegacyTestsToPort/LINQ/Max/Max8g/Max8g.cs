using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: decimal?, selector function is called
        public static int Test8g()
        {
            Data_Ndecimal[] source = new Data_Ndecimal[]{ new Data_Ndecimal{name="Tim", num=420.5m},
                                                new Data_Ndecimal{name="John", num=null},
                                                new Data_Ndecimal{name="Bob", num=10.45m}
            };
            decimal expected = 420.5m;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test8g();
        }
    }
}
