using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-7: resultSelector is null
        public static int Test9c()
        {
            // Key anagram of Tim
            string[] key = { "Tim", "Tim", "Tim", "Tim" };
            int[] element = { 60, -10, 40, 100 };
            Record[] source = new Record[]{    new Record{Name = "Tim", Score = element[0]},
                                                new Record{Name = "Tim", Score = element[1]},
                                                new Record{Name = "miT", Score = element[2]},                
                                                new Record{Name = "miT", Score = element[3]},
            };
            Func<string, IEnumerable<Record>, long> res1 = Helper.resultSelect1;

            try
            {
                res1 = null;
                var result = source.GroupBy((e) => e.Name, res1, new AnagramEqualityComparer());
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
            return Test9c();
        }
    }
}
