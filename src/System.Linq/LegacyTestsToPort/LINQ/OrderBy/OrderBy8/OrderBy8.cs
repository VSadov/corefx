using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderBy
{
    public class Test
    {
        // Overload-2: All elements have same keys, verify Order is preserved
        public static int Test8()
        {
            Record[] source = new Record[]{ new Record{Name = "Tim", Score = 90},
                                            new Record{Name = "Robert", Score = 90},
                                            new Record{Name = "Prakash", Score = 90},
                                            new Record{Name = "Jim", Score = 90},
                                            new Record{Name = "John", Score = 90},
                                            new Record{Name = "Albert", Score = 90},
            };
            Record[] expected = new Record[]{new Record{Name = "Tim", Score = 90},
                                            new Record{Name = "Robert", Score = 90},
                                            new Record{Name = "Prakash", Score = 90},
                                            new Record{Name = "Jim", Score = 90},
                                            new Record{Name = "John", Score = 90},
                                            new Record{Name = "Albert", Score = 90},
            };

            var actual = source.Select((e, i) => new { V = e, I = i }).OrderBy((e) => e.V.Score).ThenBy((e) => e.I).Select((e) => e.V);
            //var actual = source.OrderBy((e) => e.Score, null);

            return Verification.Allequal(expected, actual);
        }


        public static int Main()
        {
            return Test8();
        }
    }
}
