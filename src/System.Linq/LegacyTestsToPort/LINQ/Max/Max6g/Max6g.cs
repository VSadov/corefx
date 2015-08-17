using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double?, selector function is called
        public static int Test6g()
        {
            Data_Ndouble[] source = new Data_Ndouble[]{ new Data_Ndouble{name="Tim", num=40.5},
                                                new Data_Ndouble{name="John", num=null},
                                                new Data_Ndouble{name="Bob", num=100.45}
            };
            double expected = 100.45;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6g();
        }
    }
}
