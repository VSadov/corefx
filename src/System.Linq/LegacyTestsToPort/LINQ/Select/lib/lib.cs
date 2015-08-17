using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Select
{
    public struct CustomerRec
    {
#pragma warning disable 0649
        public string name;
        public int custID;
#pragma warning restore 0649
    }

    public class Helper
    {
        // selector function to test index=0
        public static string index_zero(CustomerRec cr, int index)
        {
            if (index == 0) return cr.name;
            else return null;
        }

        // selector function to test index=max value is right
        // Tests if index increments correctly
        public static string index_five(CustomerRec cr, int index)
        {
            if (index == 5) return cr.name;
            else return null;
        }
    }
}
