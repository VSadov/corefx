using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sum
{
    public class Test
    {
        // Type: double, selector function is called
        public static int Test5g()
        {
            Data_double[] source = new Data_double[]{ new Data_double{name="Tim", num=9.5},
                                                new Data_double{name="John", num=10.5},
                                                new Data_double{name="Bob", num=3.5}
            };
            double expected = 23.5;

            var actual = source.Sum((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test5g();
        }
    }
}
