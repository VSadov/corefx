using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: int?, selector function is called
        public static int Test2g()
        {
            Data_Nint[] source = new Data_Nint[]{ new Data_Nint{name="Tim", num=10},
                                                new Data_Nint{name="John", num=null},
                                                new Data_Nint{name="Bob", num=-30}
            };
            int? expected = -20;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2g();
        }
    }
}
