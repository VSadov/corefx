using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: float?, selector function is called
        public static int Test11g()
        {
            Data_Nfloat[] source = new Data_Nfloat[]{ new Data_Nfloat{name="Tim", num=40.5f},
                                                new Data_Nfloat{name="John", num=null},
                                                new Data_Nfloat{name="Bob", num=100.45f}
            };
            float? expected = 100.45f;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11g();
        }
    }
}
