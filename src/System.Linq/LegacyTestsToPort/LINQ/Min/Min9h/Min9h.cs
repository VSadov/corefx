using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Min
{
    public class Test
    {
        // Type: string, selector function is called
        public static int Test9h()
        {
            Data_string[] source = new Data_string[]{ new Data_string{name="Tim", num=100.45m},
                                                new Data_string{name="John", num=10.5m},
                                                new Data_string{name="Bob", num=0.05m}
            };
            string expected = "Bob";

            var actual = source.Min((e) => e.name);

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test9h();
        }
    }
}
