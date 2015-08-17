using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GroupBy
{
    public class Test
    {
        // Overload-4: Duplicate keys are present
        public static int Test5()
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

            var result = source.GroupBy((e) => e.Name, (e) => e.Score);

            return Verification.MatchAll(key, element, result);
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
