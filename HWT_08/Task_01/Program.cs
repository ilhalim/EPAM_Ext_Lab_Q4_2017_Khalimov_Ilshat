namespace Task_01
{
    using System;
    using System.Collections.Generic;

    public class Program //todo pn всё в одном классе
        {
       public delegate void Sort(List<string> words, int num1, int num2);

        public static void SortByAlhabet(List<string> words, int num1, int num2)
        {
            if (NeedToReOrder(words[num1], words[num2]))
            {
                string s = words[num1];
                words[num1] = words[num2];
                words[num2] = s;
            }
        }

        public static bool NeedToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i])
                {
                    return false;
                }

                if (s1.ToCharArray()[i] > s2.ToCharArray()[i])
                {
                    return true;
                }
            }

            return false;
        }

        public static void SortByLenght(List<string> words, int num1, int num2)
        {
            if (words[num1].Length > words[num2].Length)
                {
                    string s = words[num1];
                words[num1] = words[num2];
                words[num2] = s;
                }
            }

            public static void ReadList(List<string> words, int number)
            {
                for (int i = 0; i < number; i++)
                {
                    string word = Console.ReadLine();
                    words.Add(word);
                }
            }

    public static int ReadNumber()
        {
                int number;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        if (number <= 0)
                        {
                            string s = "Error.Please write correct value";
                            MyWrite(s);
                        }
                        else
                        {
                            break;
                        }                        
                    }
                    else
                    {
                        string s = "Error.Please write correct value";
                        MyWrite(s);
                    }
                }

                return number;
            }

            public static void MyWrite(string s)
            {
                Console.WriteLine(s);
            }

            public static void WriteList(List<string> words)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    MyWrite(words[i]);
                }
            }

            public static void SortList(List<string> words)
            {
                Sort sortbyAlphabet = new Sort(SortByAlhabet);
                Sort sortbyLenght = new Sort(SortByLenght);
                for (int i = 0; i < words.Count; i++)
                {
                    for (int j = 0; j < words.Count - 1; j++)
                    {
                        if (words[j].Length == words[j + 1].Length)
                        {
                            sortbyAlphabet(words, j, j + 1);
                        }
                        else
                        {
                            sortbyLenght(words, j, j + 1);
                        }
                    }
                }
            }

        public static void Main(string[] args)
        {
            while (true)
            { 
            List<string> words = new List<string> { };
            string s = "Please write number of words";
            MyWrite(s);
            int count = ReadNumber();
            s = "Please write your words";
            MyWrite(s);
            ReadList(words, count);
            SortList(words);
            s = "Words after sort";
            MyWrite(s);
            WriteList(words);

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
