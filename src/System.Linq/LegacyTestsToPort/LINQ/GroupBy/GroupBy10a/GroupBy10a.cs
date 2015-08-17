using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-8: source is null
        public static int Test10a()
        {
            string[] key = { "Tim", "Tim", "Chris", "Chris", "Robert", "Prakash" };
            int[] element = { 55, 25, 49, 24, -100, 9 };
            Record[] source = new Record[]{    new Record{Name = "Tim", Score = 55},
                                                new Record{Name = "Chris", Score = 49},
                                                new Record{Name = "Robert", Score = -100},                
                                                new Record{Name = "Chris", Score = 24},
                                                new Record{Name = "Prakash", Score = 9},
                                                new Record{Name = "Tim", Score = 25},
            };
            Func<string, IEnumerable<int>, long> res2 = Helper.resultSelect2;

            try
            {
                source = null;
                var result = source.GroupBy((e) => e.Name, (e) => e.Score, res2, new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentNullException ane)
            {
                if (ane.CompareParamName("source")) return 0;
                return 1;
            }
        }


        public static int Main()
        {
            return Test10a();
        }
    }
}
