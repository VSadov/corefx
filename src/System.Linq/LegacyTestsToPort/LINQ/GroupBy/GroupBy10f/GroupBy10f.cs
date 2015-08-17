using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-8: Duplicate keys are present
        // Also tests Equality Comparer is called
        public static int Test10f()
        {
            string[] key = { "Tim", "Tim", "Chris", "Chris", "Robert", "Prakash" };
            int[] element = { 55, 25, 49, 24, -100, 9 };
            Record[] source = new Record[]{    new Record{Name = "Tim", Score = 55},
                                                new Record{Name = "Chris", Score = 49},
                                                new Record{Name = "Robert", Score = -100},                
                                                new Record{Name = "Chris", Score = 24},
                                                new Record{Name = "Prakash", Score = 9},
                                                new Record{Name = "miT", Score = 25},
            };
            Func<string, IEnumerable<int>, long> res2 = Helper.resultSelect2;
            long[] expected = { 240, 365, -600, 63 };

            var result = source.GroupBy((e) => e.Name, (e) => e.Score, res2, new AnagramEqualityComparer());

            return Verification.Allequal(expected, result);
        }


        public static int Main()
        {
            return Test10f();
        }
    }
}
