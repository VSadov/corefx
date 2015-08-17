using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: string, selector function is called
        public static int Test9h()
        {
            Data_string[] source = new Data_string[]{ new Data_string{name="Tim", num=420.5m},
                                                new Data_string{name="John", num=900.25m},
                                                new Data_string{name="Bob", num=10.45m}
            };
            string expected = "Tim";

            var actual = source.Max((e) => e.name);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9h();
        }
    }
}
