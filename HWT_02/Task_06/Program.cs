namespace Task_06
{
    using System;
    
    public class Program
    {
        public static void TextControl(bool[] txt)
        {           
            Console.Write("the label parameters:");
            if (txt[0])
            {
                Console.Write("Bold ");
            }

            if (txt[1])
            {
                Console.Write("Italic ");
            }

            if (txt[2])
            {
                Console.Write("Underline ");
            }

            if ((!txt[0]) && (!txt[1]) && (!txt[2]))
            {
                Console.Write("None");
            }

            Console.WriteLine();
            Console.WriteLine("Write:");
            Console.WriteLine("1:Bold");
            Console.WriteLine("2:Italic");
            Console.WriteLine("3:Underline");
            int i = int.Parse(Console.ReadLine());
            if (txt[i - 1] == false)
            {
                txt[i - 1] = true;
            }
            else
            {
                txt[i - 1] = false;
                    }
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool[] txt = new bool[3];
            while (true)
            {
                TextControl(txt);
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
