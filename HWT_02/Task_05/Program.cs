namespace Task_05
{
    using System;

    public class Program
    {
        public static int Summary()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of nubmers = {0}", Summary());
            Console.ReadLine();
        }
    }
}
