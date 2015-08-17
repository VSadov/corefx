using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    public class Test
    {
        // Overload-2: Verify Order is preserved
        public static int Test8()
        {
            Record[] source = new Record[]{ new Record{Name = "Alpha", Score = 90},
                                            new Record{Name = "Robert", Score = 45},
                                            new Record{Name = "Prakash", Score = 99},
                                            new Record{ Name = "Bob", Score = 90},
                                            new Record{Name = "Thomas", Score = 45},
                                            new Record{Name = "Tim", Score = 45},
                                            new Record{Name = "Mark", Score = 45},
            };
            Record[] expected = new Record[]{new Record{Name = "Prakash", Score = 99},
                                             new Record{Name = "Alpha", Score = 90},
                                             new Record{ Name = "Bob", Score = 90},
                                             new Record{Name = "Robert", Score = 45},
                                             new Record{Name = "Thomas", Score = 45},
                                             new Record{Name = "Tim", Score = 45},
                                             new Record{Name = "Mark", Score = 45},
            };

            var actual = source.Select((e, i) => new { V = e, I = i }).OrderByDescending((e) => e.V.Score).ThenBy((e) => e.I).Select((e) => e.V);
            //var actual = source.OrderByDescending((e) => e.Score, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
