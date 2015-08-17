using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: double, selector function is called
        public static int Test5f()
        {
            Data_double[] source = new Data_double[]{ new Data_double{name="Tim", num=5.5},
                                                      new Data_double{name="John", num=15.5},
                                                      new Data_double{name="Bob", num=3.0}
            };
            double expected = 8.0;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5f();
        }
    }
}
