namespace Task_02
{
    using System;

    public class Program
    {
        public static void PositiveToZero(int[,,] array, int numberofelements)
        {            
            for (int i = 0; i < numberofelements; i++)
            {
                for (int j = 0; j < numberofelements; j++)
                {
                    for (int k = 0; k < numberofelements; k++)
                    {
                        if (array[i, j, k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    }
                }
            }                       
        }
        
        public static void RandArray(int[,,] array, int numberofelements)
        {
            Random randomize = new Random();
            for (int i = 0; i < numberofelements; i++)
            {
                for (int j = 0; j < numberofelements; j++)
                {
                    for (int k = 0; k < numberofelements; k++)
                    {
                        array[i, j, k] = randomize.Next(-100, 100);
                    }
                }
            }
        }

        public static void PrintArray(int[,,] array, int numberofelements)
        {
            for (int i = 0; i < numberofelements; i++)
            {
                for (int j = 0; j < numberofelements; j++)
                {
                    for (int k = 0; k < numberofelements; k++)
                    {
                        Console.Write("{0} ", array[i, j, k]);
                }

                Console.WriteLine();
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

                int[,,] array = new int[numberofelements, numberofelements, numberofelements];
                RandArray(array, numberofelements);
                Console.WriteLine("The array:");
                PrintArray(array, numberofelements);
                PositiveToZero(array, numberofelements);
                Console.WriteLine("The modifed array:");
                PrintArray(array, numberofelements);
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