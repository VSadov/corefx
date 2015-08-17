using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: float?, selector function is called
        public static int Test10g()
        {
            Data_Nfloat[] source = new Data_Nfloat[]{ new Data_Nfloat{name="Tim", num=9.5f},
                                                new Data_Nfloat{name="John", num=null},
                                                new Data_Nfloat{name="Bob", num=8.5f}
            };
            float? expected = 18.0f;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test10g();
        }
    }
}
