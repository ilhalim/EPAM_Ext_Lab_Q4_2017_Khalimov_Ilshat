namespace Task_03
{
    using System;

    public class Program
    {
        public static void ReadElementOfArray(int[] array, int i)
        {
            while (true)
            {
                Console.Write("Plese array[{0}]: ", i + 1);
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error.Please write correct value");
                }
            }
        }              

        public static int SumOfNonNegative(int[] array)
        {
            int sumofnonnegative = 0;
            for (int i = 0; i < array.Length; i++)
            {                
                if (array[i] >= 0)
                {
                    sumofnonnegative = sumofnonnegative + array[i];
                }
            }

            return sumofnonnegative;
        }
        
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                int numberofelements;
                int sumofnonnegative;
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

                int[] array = new int[numberofelements];
                for (int i = 0; i < array.Length; i++)
                {
                    ReadElementOfArray(array, i);
                }

                Console.Write("The array: ");
                PrintArray(array);
                sumofnonnegative = SumOfNonNegative(array);
                Console.WriteLine("The sum of positive numbers = {0}", sumofnonnegative);
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