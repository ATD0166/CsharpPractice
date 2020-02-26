using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPracticeApp1
{
    static public class ExtendMethod
    {
        static public char PickInitial(this string s)
        {
            char[] chars = s.ToCharArray();
            return chars[0];
        }
    }
}
