using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

#pragma warning disable 0649
namespace Join
{
    // Class which is passed as an argument for EqualityComparer
    public class AnagramEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return getCanonicalString(x) == getCanonicalString(y);
        }

        public int GetHashCode(string obj)
        {
            return getCanonicalString(obj).GetHashCode();
        }

        private string getCanonicalString(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Sort<char>(wordChars);
            return new string(wordChars);
        }
    }

    public struct CustomerRec
    {
        public string name;
        public int custID;
    }

    public struct OrderRec
    {
        public int orderID;
        public int custID;
        public int total;
    }

    public struct AnagramRec
    {
        public string name;
        public int orderID;
        public int total;
    }

    public struct JoinRec
    {
        public string name;
        public int orderID;
        public int total;
    }

    public class Helper
    {
        public static JoinRec createJoinRec(CustomerRec cr, OrderRec or)
        {
            JoinRec jr = new JoinRec();

            jr.name = cr.name;
            jr.orderID = or.orderID;
            jr.total = or.total;

            return jr;
        }

        public static JoinRec createJoinRec(CustomerRec cr, AnagramRec or)
        {
            JoinRec jr = new JoinRec();

            jr.name = cr.name;
            jr.orderID = or.orderID;
            jr.total = or.total;

            return jr;
        }
    }
}