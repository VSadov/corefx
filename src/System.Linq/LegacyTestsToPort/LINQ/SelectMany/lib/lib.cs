using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SelectMany
{
    public struct CustomerRec
    {
#pragma warning disable 0649
        public string name;
        public int?[] total;
#pragma warning restore 0649
    }

    public class Helper
    {
        // Helper function to test index=0
        public static IEnumerable<int?> index_zero(CustomerRec cr, int index)
        {
            if (index == 0) return cr.total;
            else return new int?[] { };
        }

        // Helper function to test index=max value
        public static IEnumerable<int?> index_four(CustomerRec cr, int index)
        {
            if (index == 4) return cr.total;
            else return new int?[] { };
        }
    }
}
