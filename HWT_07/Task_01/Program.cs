namespace Task_01
{
    using System;
    using System.Collections.Generic;

   public class Program
    {        
        public static void FillRoundofPeople(List<int> roundofpeople, int numberofpeople)
        {
            for (int i = 2; i <= numberofpeople; i++)
            {
                roundofpeople.Add(i);
            }
        }

        public static void ViewRoundofPeople(List<int> roundofpeople)
        {
            string s = "Round of people at this moment";
            MyWrite(s);
            for (int j = 0; j < roundofpeople.Count; j++)
            {
                Console.Write("{0} ", roundofpeople[j]);
            }

            Console.WriteLine();
        }

        public static void RemoveEvenPosition(List<int> roundofpeople)
        {
            for (int i = 0; i < roundofpeople.Count; i++)
            {
                if (roundofpeople.Count % 2 == 1)
                {
                    if (i % 2 == 1)
                    {
                        roundofpeople.RemoveAt(i);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        roundofpeople.RemoveAt(i);
                    }
                }
            }
        }

        public static void RemoveOddPosition(List<int> roundofpeople)
        {
            for (int i = 0; i < roundofpeople.Count; i++)
            {
                if (roundofpeople.Count % 2 == 0)
                {
                    if (i % 2 == 1)
                    {
                        roundofpeople.RemoveAt(i);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        roundofpeople.RemoveAt(i);
                    }
                }
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
                List<int> roundofpeople = new List<int> { 1 };
            int numberofpeople;
            string s = "Please write number of people in the round";
            MyWrite(s);
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numberofpeople))
                {
                    if (numberofpeople <= 0)
                    {
                        Console.WriteLine("Error.Please write correct value");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Error.Please write correct value");
                }
            }

            FillRoundofPeople(roundofpeople, numberofpeople);
            ViewRoundofPeople(roundofpeople);
            int shetchikcrugov = 1;
            while (roundofpeople.Count != 1)
            {
                if (shetchikcrugov % 2 == 1)
                {
                    RemoveEvenPosition(roundofpeople);
                }
                else
                {
                    RemoveOddPosition(roundofpeople);
                }

                shetchikcrugov++;
                ViewRoundofPeople(roundofpeople);
            }

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
