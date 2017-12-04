namespace Task_04
{
    using System;

    public class Program
    {
        public static int SumOfEvenPos(int[,] array, int numberofelements)
        {
            int sumofevenpos = 0;
            for (int i = 0; i < numberofelements; i++)
            {
                for (int j = 0; j < numberofelements; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sumofevenpos = sumofevenpos + array[i, j];
                    }
                }
            }

            return sumofevenpos;
        }

        public static void RandArray(int[,] array, int numberofelements)
        {
            Random randomize = new Random();
            for (int i = 0; i < numberofelements; i++)
            {
                for (int j = 0; j < numberofelements; j++)
                {
                    array[i, j] = randomize.Next(100);
                }
           }
        }               

        public static void PrintArray(int[,] array, int numberofelements)
        {
            for (int i = 0; i < numberofelements; i++)
            {
                for (int j = 0; j < numberofelements; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }

                Console.WriteLine();
            }            
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                int numberofelements;
                Console.Write("Please write number of elements: ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out numberofelements))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value");
                    }
                }

                int[,] array = new int[numberofelements, numberofelements];
                RandArray(array, numberofelements);
                Console.WriteLine("The array:");
                PrintArray(array, numberofelements);
                int sumofevenpos = SumOfEvenPos(array, numberofelements);
                Console.WriteLine("The Sum of elements on even position = {0}", sumofevenpos);
                Console.Write("For close program use button Escape(Esp): ");
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}