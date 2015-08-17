using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ThenBy
{
    // Class which is passed as an argument for EqualityComparer
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x.ToLower(), y.ToLower());
        }
    }

    struct Record
    {
#pragma warning disable 0649
        public string Name;
        public string City;
        public string Country;
#pragma warning restore 0649
    }
}
