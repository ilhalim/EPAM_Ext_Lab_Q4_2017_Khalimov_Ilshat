namespace Task_02
{
    using System;
    using System.Text;

    public class Program
    {
        public static string Newstring(StringBuilder sb, string s)
        {            
            for (int i = 0; i < sb.Length; i++)
            {
                bool isnodoubled = true;
                for (int j = 0; j < s.Length; j++)
                {
                    if ((sb[i] == s[j]) && isnodoubled)
                    {
                        sb.Insert(i, s[j]);
                        i++;
                       isnodoubled = false;
                    }
                }
            }

            return sb.ToString();          
        }

        public static void Main(string[] args)
        {
            while (true)            
            { 
            Console.WriteLine("Please write first string");     
            StringBuilder firststring = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Please write second string");
            string secondstring = Console.ReadLine();
            Console.WriteLine("The new string:");
            Console.WriteLine(Newstring(firststring, secondstring));
            Console.ReadKey();
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
