namespace Task_02
{
    using System;

    public static class MyHelperMethods
    {
        public static bool IsPositive(this string s)
        {
            if ((s[0] == '-') && s.IsNumber())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsNumber(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (((s[i] < '0') || (s[i] > '9')) && (s[0] != '-'))
                {
                    return false;
                }                                
            }

            return true;
        }
    }
}
