using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: int?, selector function is called
        public static int Test2g()
        {
            Data_Nint[] source = new Data_Nint[]{ new Data_Nint{name="Tim", num=10},
                                                new Data_Nint{name="John", num=-105},
                                                new Data_Nint{name="Bob", num=null}
            };
            int? expected = 10;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test2g();
        }
    }
}
