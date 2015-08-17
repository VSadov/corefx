using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-6: keySelector is null
        public static int Test8b()
        {
            string[] key = { "Tim", "Chris", "Robert", "Prakash" };
            int[] element = { 60, -10, 40, 100 };
            Record[] source = new Record[]{    new Record{Name = key[0], Score = element[0]},
                                                new Record{Name = key[1], Score = element[1]},
                                                new Record{Name = key[2], Score = element[2]},                
                                                new Record{Name = key[3], Score = element[3]},
            };
            Func<string, IEnumerable<int>, long> res2 = Helper.resultSelect2;

            try
            {
                var result = source.GroupBy(null, (e) => e.Score, res2);
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (ane.CompareParamName("keySelector")) return 0;
                return 1;
            }
        }


        public static int Main()
        {
            return Test8b();
        }
    }
}
