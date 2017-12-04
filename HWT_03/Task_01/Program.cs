namespace Task_01
{
    using System;

   public class Program
    {   
        public static void RandArray(int[] array)
        {            
            Random randomize = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomize.Next(100);
            }
        }

        public static void SortArray(int[] array)
        {
            int temp; // временная переменная для сортировки
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }           
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
                    RandArray(array);
                    Console.Write("The array: ");
                    PrintArray(array);
                    SortArray(array);
                    Console.Write("the sorted ascending array: ");
                    PrintArray(array);
                    Console.WriteLine("Max elemaent = {0}", array[0]);
                    Console.WriteLine("Min elemaent = {0}", array[numberofelements - 1]);
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