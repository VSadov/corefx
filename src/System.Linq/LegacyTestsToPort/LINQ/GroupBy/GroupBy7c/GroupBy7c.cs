using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-5: resultSelector is null
        public static int Test7c()
        {
            string[] key = { "Tim" };
            int[] element = { 60 };
            Record[] source = new Record[] { new Record { Name = key[0], Score = element[0] } };
            Func<string, IEnumerable<Record>, long> res1 = Helper.resultSelect1;

            try
            {
                res1 = null;
                var result = source.GroupBy((e) => e.Name, res1);
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (ane.CompareParamName("resultSelector")) return 0;
                return 1;
            }
        }


        public static int Main()
        {
            return Test7c();
        }
    }
}
