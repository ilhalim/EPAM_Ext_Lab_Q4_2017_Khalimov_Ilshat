namespace Task_01
{
    using System;

    public class Circle //todo pn один файл - один класс
    {
        public double X;
        public double Y;
        public int R; 

        public double GetLegth()
        {
            return 2 * Math.PI * this.R;
        }

        public double DistanseFromPoint(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow(this.X - x1, 2) + Math.Pow(this.Y - y1, 2));
        }
    }

    public class Round : Circle
    {
        public double GetArea()
        {
        return Math.PI * this.R * this.R;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var myround = new Round();
            while (true)
            {
                Console.WriteLine("Please write value of x");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out myround.X))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of x");
                    }
                }

                Console.WriteLine("Please write value of y");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out myround.Y))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of y");
                    }
                }

                Console.WriteLine("Please write radius of circle");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out myround.R))
                    {
                        if (myround.R <= 0)
                        {
                            Console.WriteLine("Error.Please write correct value of r");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of r");
                    }
                }

                var length = myround.GetLegth();
                Console.WriteLine("Circumference : {0}", length);
                var area = myround.GetArea();
                Console.WriteLine("The area of a circle : {0}", area);
                var distanse = myround.DistanseFromPoint(0, 0);
                Console.WriteLine("Tру distance from the origin to the center of the circle : {0}", distanse);
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
