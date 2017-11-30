namespace Task_01
{
    using System;
        
    public class Program
    {
        public static int Area(int a, int b)
        {
            return a * b;
        }

        public static void Main(string[] args)
        {
            int a, b, s;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Please write a");
                    if (int.TryParse(Console.ReadLine(), out a))
                    {
                        if (a < 1)
                        {
                            Console.WriteLine("Error.Please write correct value of a ");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of a ");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Please write b");
                    if (int.TryParse(Console.ReadLine(), out b))
                    {
                        if (a < 1)
                        {
                            Console.WriteLine("Error.Please write correct value of b ");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of b ");
                    }
                }

               s = Area(a, b);
                Console.WriteLine("The rectangle area = {0} ", s);
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
