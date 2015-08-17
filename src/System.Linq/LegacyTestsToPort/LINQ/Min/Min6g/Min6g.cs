using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double?, selector function is called
        public static int Test6g()
        {
            Data_Ndouble[] source = new Data_Ndouble[]{ new Data_Ndouble{name="Tim", num=-45.5},
                                                new Data_Ndouble{name="John", num=-132.5},
                                                new Data_Ndouble{name="Bob", num=null}
            };
            double expected = -132.5;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test6g();
        }
    }
}
