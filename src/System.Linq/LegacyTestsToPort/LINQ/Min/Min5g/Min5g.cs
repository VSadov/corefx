using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: double, selector function is called
        public static int Test5g()
        {
            Data_double[] source = new Data_double[]{ new Data_double{name="Tim", num=-45.5},
                                                new Data_double{name="John", num=-132.5},
                                                new Data_double{name="Bob", num=20.45}
            };
            double expected = -132.5;

            var actual = source.Min((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5g();
        }
    }
}
