using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: float, selector function is called
        public static int Test9e()
        {
            Data_float[] source = new Data_float[]{     new Data_float{name="Tim", num=5.5f},
                                                        new Data_float{name="John", num=15.5f},
                                                        new Data_float{name="Bob", num=3.0f}
            };
            float expected = 8.0f;

            var actual = source.Average((e) => e.num);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9e();
        }
    }
}
