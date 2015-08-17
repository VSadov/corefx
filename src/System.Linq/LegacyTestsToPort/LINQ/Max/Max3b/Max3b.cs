using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Max
{
    public class Test
    {
        // Type: long, source has only one element
        public static int Test3b()
        {
            long[] source = { (long)Int32.MaxValue + 10 };
            long expected = (long)Int32.MaxValue + 10;

            var actual = source.Max();

Console.WriteLine("actual {0}", actual);
Console.WriteLine("expected  {0}", expected );

            return ((expected == actual) ? 0 : 1);
        }


        public static int Main()
        {
            return Test3b();
        }
    }
}
