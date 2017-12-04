namespace Task_05
{
    using System;

    public class Program
    {
        public static int Summary()//todo pn частное решение для общей задачи
		{
            int sum = 0;
            for (int i = 1; i <= 1000; i++)//todo pn хардкод
			{
                if ((i % 3 == 0) || (i % 5 == 0))//todo pn хардкод
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
