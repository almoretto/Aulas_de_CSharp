
using System.Runtime.CompilerServices;

namespace System
{
    static class StringExtensions
    {
        public static String Cut(this string thisObj, int count) //Patern of signature
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}
