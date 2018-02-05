namespace Task_02
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please write string");
                string numberinstring = Console.ReadLine();
                string s;
                if (numberinstring.IsNumber())
                {
                    if (numberinstring.IsPositive())
                    {
                        s = "Positive number";//todo pn хардкод
					}
                    else
                    {
                        s = "Non-positive number";//todo pn хардкод
					}
                }
                else
                {
                    s = "not a number";//todo pn хардкод
				}

                Console.WriteLine("The string is {0}", s);
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
