namespace Task_02
{
    using System;

public class Triangle
    {
        public int A;
        public int B;
        public int C;

        public double GetPerimeter()
        {
            return this.A + this.B + this.C;
        }

        public double GetArea()
        {
            return Math.Sqrt((this.GetPerimeter() / 2) * ((this.GetPerimeter() / 2) - this.A) * ((this.GetPerimeter() / 2) - this.B) * ((this.GetPerimeter() / 2) - this.C));
        }
    }        

    public class Program
    {
        public static void Main(string[] args)
        {
            var mytriangle = new Triangle();
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Please write value of a");
                
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out mytriangle.A))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error.Please write correct value of a");
                        }
                    }

                    Console.WriteLine("Please write value of b");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out mytriangle.B))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error.Please write correct value of b");
                        }
                    }

                    Console.WriteLine("Please write value of c");
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out mytriangle.C))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error.Please write correct value of c");
                        }
                    }

                    if ((mytriangle.C + mytriangle.A <= mytriangle.B) || (mytriangle.A + mytriangle.B <= mytriangle.C) || (mytriangle.B + mytriangle.C <= mytriangle.A))
                    {
                        Console.WriteLine("Error.It is impossible to create a triangle with the given sides");
                    }
                    else
                    {
                        break;
                     }
                }

                var perimeter = mytriangle.GetPerimeter();
                Console.WriteLine("The perimeter of triangle : {0}", perimeter);
                var area = mytriangle.GetArea();
                Console.WriteLine("The area of a triangle : {0}", area);
               
                Console.Write("For close program use button Escape(Esp): ");
                ConsoleKeyInfo c = Console.ReadKey();
                Console.WriteLine();
                if (c.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
