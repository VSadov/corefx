using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ElementAt
{
    public class Test
    {
        // source is of type IList, index < 0;
        public static int Test1()
        {
            int[] source = {9, 8};
            int index = -1;

            IList<int> list = source as IList<int>;

            if (list == null) return 1;

            try
            {
                var actual = source.ElementAt(index);
                return 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0;
            } catch (IndexOutOfRangeException) {
   	       Console.WriteLine("Actually caught IndexOutOfRange");
return 1;
	    }
        }


        public static int Main()
        {
            return Test1();
        }
    }
}
