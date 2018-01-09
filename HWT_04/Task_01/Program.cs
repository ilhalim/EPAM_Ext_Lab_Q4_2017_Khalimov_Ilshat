namespace Task_01
{
    using System;
    using System.Collections.Generic;

    public class Program
    {           
        public static void WriteList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("The word {0} have {1} character", list[i], list[i].Length);
            }
        }

        public static void StringToList(string s, List<string> list)
        {
            int startindex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsSeparator(s[i]) || (s[i] == '.'))
                {
                    list.Add(s.Substring(startindex, i - startindex));
                    startindex = i + 1;
                }
            }

            list.Add(s.Substring(startindex, s.Length - startindex));
        }

        public static int AverageNumberofCharacter(List<string> list)
        {
            int numberofcharacter = 0;
            for (int i = 0; i < list.Count; i++)
            {
                numberofcharacter += list[i].Length;
            }

            return numberofcharacter / list.Count;
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please write string");
                string wordswithseparotor = Console.ReadLine();
            List<string> words = new List<string> { };
            StringToList(wordswithseparotor, words);
            WriteList(words);
            int averagenumber = AverageNumberofCharacter(words);
            Console.WriteLine("The average number of character = {0}", averagenumber);
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
