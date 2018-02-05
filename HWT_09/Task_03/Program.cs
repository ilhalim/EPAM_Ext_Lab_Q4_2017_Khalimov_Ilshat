namespace Task_03
{
using System;
using System.Diagnostics;
using System.Linq;

  public class Program
    {        
        public delegate void Search(int[] array);

        public delegate void Searchbyanonymised(int[] array);

        public static void RandArray(int[] array)
        {
            Random randomize = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomize.Next(100);
            }
        }

        public static void Main(string[] args)//todo pn запускаешь программу и попадаешь в матрицу. Ничего не понятно.
        {            
            int[] numbers = new int[1000];
            double miliseconds = 0;
            RandArray(numbers);                        
            int numberofexpiriance = 100;            
            Search searchpositive = new Search(MyHelperMethods.WritePositive);
            Func<int, bool> searchbylebda = n => n > 0;
            var searchnylinq = from n in numbers
                               where n > 0
                               select n;
            Searchbyanonymised searchbyanonymised = delegate(int[] n)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    if (n[i] > 0)
                    {
                        Console.Write("{0} ", numbers[i]);
                    }
                        }
            };
            for (int j = 0; j < numberofexpiriance; j++)
             {
                 var stopWatch = new Stopwatch();
                 stopWatch.Start();
                foreach (var x in searchnylinq)
                {
                    Console.Write("{0} ", x.ToString());
                } ////averagetime = 35.7
                 searchpositive(numbers); ////averagetime = 35.8
                 MyHelperMethods.WritePositive(numbers); ////averagetime = 36.2               
                searchbyanonymised(numbers); //// averagetime = 36.3
                  for (int i = 0; i < numbers.Length; i++)
                {
                    if (searchbylebda(numbers[i]))
                    {
                        Console.Write("{0} ", numbers[i]);
                    }
                }  ////averagetime = 36.9
                stopWatch.Stop();
            if ((j != 0) && (j != 99))
            {
                miliseconds += stopWatch.Elapsed.TotalMilliseconds;
            }
        }

        double averagetime = miliseconds / numberofexpiriance;
            Console.WriteLine(averagetime);
            Console.ReadKey();
    }        
    }
}
