namespace Task_03
{
    using System;
    using System.Diagnostics;
    using System.Text;    

    public class Program
    {
       public delegate void Timer(int n);

       public static void WorkofString(int n)
        {
            string str = string.Empty;
            for (int i = 0; i < n; i++)
            {
                str += "*";
            }
        }

        public static void WorkofStringBuilder(int n)
        {
            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("*");
            }
        }

       public static void Main(string[] args)
        {
            int numberofexpiriance = 100;
            double miliseconds = 0;
            for (int j = 0; j < numberofexpiriance; j++)
            {
                var stopWatch = new Stopwatch();
                stopWatch.Start();                              
                int n = 10000;
                Timer timerofstring = new Timer(WorkofString);
                timerofstring(n);
                Timer timerofstringbuilder = new Timer(WorkofStringBuilder);
                 timerofstringbuilder(n);
                stopWatch.Stop();
                if ((j != 0) && (j != 99))
                {
                    miliseconds += stopWatch.Elapsed.TotalMilliseconds;
                }                                             
            }

            double averagetime = miliseconds / numberofexpiriance;
            Console.WriteLine(averagetime);
            Console.ReadKey();
            /*string       
                n = 10000 averagetime=12.509
                n = 1000 averagetime=0.293
                n = 100 averagetime=0.008
            StringBuilder
                n = 10000 averagetime=0.556
                n = 1000 averagetime=0.075
                n = 100 averagetime=0.013
                */
        }
    }
}