using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float?, selector function is called
        public static int Test10g()
        {
            Data_Nfloat[] source = new Data_Nfloat[]{     new Data_Nfloat{name="Tim", num=5.5f},
                                                          new Data_Nfloat{name="John", num=15.5f},
                                                          new Data_Nfloat{name="Bob", num=null}
            };
            float? expected = 10.5f;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10g();
        }
    }
}
