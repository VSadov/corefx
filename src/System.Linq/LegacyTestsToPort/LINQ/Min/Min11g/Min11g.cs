using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: float?, selector function is called
        public static int Test11g()
        {
            Data_Nfloat[] source = new Data_Nfloat[]{ new Data_Nfloat{name="Tim", num=-45.5f},
                                                new Data_Nfloat{name="John", num=-132.5f},
                                                new Data_Nfloat{name="Bob", num=null}
            };
            float? expected = -132.5f;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test11g();
        }
    }
}
