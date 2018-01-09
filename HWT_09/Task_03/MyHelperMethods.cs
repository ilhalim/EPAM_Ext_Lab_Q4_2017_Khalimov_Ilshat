namespace Task_03
{
    using System;

    public static class MyHelperMethods
    {
        public static void MyWrite(string s)
        {
            Console.WriteLine(s);
        }

      public static bool IsPosotive(this int n)
            {
            if (n > 0)
            {
                return true;
            }

            return false;
            }

        public static void WritePositive(int[] numbers)
        {
            Console.Write("The pisitive numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].IsPosotive())
                {
                    Console.Write("{0} ", numbers[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
