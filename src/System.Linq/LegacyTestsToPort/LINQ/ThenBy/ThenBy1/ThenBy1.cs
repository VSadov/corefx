using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ThenBy
{
    public class Test
    {
        // Overload-1: source is empty
        public static int Test1()
        {
            int[] source = {};
            int[] expected = {};

            var actual = source.OrderBy((e)=>e).ThenBy((e)=>(e));

            return Verification.Allequal(expected, actual);
         }


        public static int Main()
        {
            return Test1();
        }
    }
}
