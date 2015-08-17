using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Average
{
    public class Test
    {
        // Type: long, OverflowException is thrown by param sum
        public static int Test3f()
        {
            long[] source = { Int64.MaxValue, Int64.MaxValue };
	    Console.WriteLine("111");
            try
            {
                var actual = source.Average();
Console.WriteLine("222");
                return 1;
            }
            catch (OverflowException)
            {
Console.WriteLine("333");
                return 0;
            }

 catch (Exception e)
            {
Console.WriteLine("4444");
Console.WriteLine(e);
                return 0;
            }
        }


        public static int Main()
        {
            return Test3f();
        }
    }
}
