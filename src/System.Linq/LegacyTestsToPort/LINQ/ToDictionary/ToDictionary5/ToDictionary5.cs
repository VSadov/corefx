using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDictionary
{
    public class Test
    {
        // Overload-4: keySelector returns duplicate values
        public static int Test5()
        {
            Record[] source =  new Record[3];

            source[0].Name = "Chris";   source[0].Score = 50;
            source[1].Name = "Bob";     source[1].Score = 95;
            source[2].Name = "Bob";     source[2].Score = 55;

            try
            {
                var result = source.ToDictionary((e)=>e.Name, (e)=>e, new AnagramEqualityComparer());
                return 1;
            }
            catch (ArgumentException)
            {
                return 0;
            }
        }


        public static int Main()
        {
            return Test5();
        }
    }
}
