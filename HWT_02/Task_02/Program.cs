namespace Task_02
{
    using System;    

   public class Program
    {
        public static void OutoutStars(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
         }

        public static void Main(string[] args)
        {
          while (true)
            {
                int n;
                while (true)
                {                   
                    Console.WriteLine("Please write n");
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of n ");
                    }
                  }   
                                      
                    OutoutStars(n);                
                Console.WriteLine("For close program use button Escape(Esp)");
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
