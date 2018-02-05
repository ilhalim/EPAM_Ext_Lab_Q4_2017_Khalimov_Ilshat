namespace Task_02
{
    using System;
    using System.Collections.Generic;

   public class Program//todo pn почему всё в одном классе?
    {
        public static void StringToList(string s, List<string> list)
        {
            int startindex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsSeparator(s[i]) || (s[i] == '.'))//todo pn точка является разделителем по умолчанию
                {
                    list.Add(s.Substring(startindex, i - startindex));
                    startindex = i + 1;
                }
            }

            list.Add(s.Substring(startindex, s.Length - startindex));
        }

        public static void ViewCopies(List<string> words, List<int> numberodwords)
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("Word {0} : has {1} copies", words[i], numberodwords[i]);//todo pn смешение логики UI и BL
            }
        }

        public static void FindCopies(List<string> words, List<int> numberodwords)
        {
            for (int j = 0; j < words.Count; j++)
            {
                numberodwords.Add(1);
                for (int i = j + 1; i < words.Count; i++)
                {
                    if (words[j].Equals(words[i]))
                    {
                        numberodwords[j]++;
                        words.RemoveAt(i);
                    }
                }
            }
        }

        public static void StringlistTolower(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].ToLower();
            }
        }

        public static void MyWrite(string s)
        {
            Console.WriteLine(s);
        }

       public static void Main(string[] args)
        {
            while (true)
            { 
            List<string> words = new List<string> { };
            List<int> numberodwords = new List<int> { };
            string s;
                s = "Please write the string to work with him";
                MyWrite(s);
            s = Console.ReadLine();
                StringToList(s, words);
                FindCopies(words, numberodwords);
                ViewCopies(words, numberodwords);
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
