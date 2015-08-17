using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: double, selector function is called
        public static int Test5g()
        {
            Data_double[] source = new Data_double[]{ new Data_double{name="Tim", num=40.5},
                                                new Data_double{name="John", num=-10.25},
                                                new Data_double{name="Bob", num=100.45}
            };
            double expected = 100.45;

            var actual = source.Max((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5g();
        }
    }
}
