namespace Task_01
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int lenghtofarray;
                string error = "Error.Please write correct value";
                string s = "Please write a lenght of array";
                MyHelperMethods.MyWrite(s);
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out lenghtofarray))
                    {
                        break;
                    }
                    else
                    {
                        MyHelperMethods.MyWrite(error);
                    }
                }

                int[] numbers = new int[lenghtofarray];
                s = "Please write a array";
                MyHelperMethods.MyWrite(s);
                for (int i = 0; i < lenghtofarray; i++)
                {
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out numbers[i]))
                        {
                            break;
                        }
                        else
                        {
                            MyHelperMethods.MyWrite(error);
                        }
                    }
                }

                int sum = numbers.SumofArray();
                s = "Sum of numbers in array:";
                MyHelperMethods.MyWrite(s);
                Console.WriteLine(sum);
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
