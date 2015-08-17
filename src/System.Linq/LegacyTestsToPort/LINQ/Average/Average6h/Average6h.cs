using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double?, selector function is called
        public static int Test6h()
        {
            Data_Ndouble[] source = new Data_Ndouble[]{ new Data_Ndouble{name="Tim", num=5.5},
                                                        new Data_Ndouble{name="John", num=15.5},
                                                        new Data_Ndouble{name="Bob", num=null}
            };
            double? expected = 10.5;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6h();
        }
    }
}
