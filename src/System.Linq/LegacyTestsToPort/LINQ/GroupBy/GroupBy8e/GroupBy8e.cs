using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-6: source has all elements with different keys.
        // Also verifies elementSelector is called
        public static int Test8e()
        {
            string[] key = { "Tim", "Chris", "Robert", "Prakash" };
            int[] element = { 60, -10, 40, 100 };
            Record[] source = new Record[]{    new Record{Name = key[0], Score = element[0]},
                                                new Record{Name = key[1], Score = element[1]},
                                                new Record{Name = key[2], Score = element[2]},                
                                                new Record{Name = key[3], Score = element[3]},
            };
            Func<string, IEnumerable<int>, long> res2 = Helper.resultSelect2;
            long[] expected = { 180, -50, 240, 700 };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score, res2);

            return Verification.Allequal(expected, result);
        }


        public static int Main()
        {
            return Test8e();
        }
    }
}
