using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = str[i];
                char b = str[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
    }
}
