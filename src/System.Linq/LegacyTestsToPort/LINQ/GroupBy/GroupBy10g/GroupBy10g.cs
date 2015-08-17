using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-8: Verifies Equality Comparer is null scenario, some of the key elements are also null
        public static int Test10g()
        {
            string[] key = { "Tim", null, null, "Robert", "Chris", "miT" };
            int[] element = { 55, 49, 9, -100, 24, 25 };
            Record[] source = new Record[]{    new Record{Name = "Tim", Score = 55},
                                                new Record{Name = null, Score = 49},
                                                new Record{Name = "Robert", Score = -100},                
                                                new Record{Name = "Chris", Score = 24},
                                                new Record{Name = null, Score = 9},
                                                new Record{Name = "miT", Score = 25},
            };
            Func<string, IEnumerable<int>, long> res2 = Helper.resultSelect2;
            long[] expected = { 165, 58, -600, 120, 75 };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score, res2, null);

            return Verification.Allequal(expected, result);
        }


        public static int Main()
        {
            return Test10g();
        }
    }
}
