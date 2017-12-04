namespace Task_03
{
    using System;

    public class Program
    {
        public static void StarsInTreangle(int n)
        {
            int[] treangle = new int[(2 * n) - 1];
        
             for (int i = 0; i < n; i++)
             {
                treangle[n - i - 1] = 1;
                treangle[n + i - 1] = 1;
                for (int j = 0; j < ((2 * n) - 1); j++)
                 {                    
                    if (treangle[j ] == 1)
                     {
                     Console.Write("*");//todo pn хардкод
					}
                     else
                     {
                     Console.Write(" ");
                     }                     
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

                StarsInTreangle(n);
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
