using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderByDescending
{
    // Class which is passed as an argument for EqualityComparer
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x.ToLower(), y.ToLower());
        }
    }

    // EqualityComparer to ignore case sensitivity: Added to support PLINQ
    public class CaseInsensitiveEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            if (string.Compare(x.ToLower(), y.ToLower()) == 0) return true;
            return false;
        }

        public int GetHashCode(string obj)
        {
            return getCaseInsensitiveString(obj).GetHashCode();
        }

        private string getCaseInsensitiveString(string word)
        {
            char[] wordchars = word.ToCharArray();
            String newWord = "";
            foreach (char c in wordchars)
            {

                newWord = newWord + (c.ToString().ToLower());
            }
            return newWord;
        }
    }

    struct Record
    {
#pragma warning disable 0649
        public string Name;
        public int Score;
#pragma warning restore 0649

    }
}
