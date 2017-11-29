/*Написать консольное приложение, которое проверяет принадлежность точки заштрихованной области.  Пользователь вводит координаты точки (x; y)
и выбирает букву графика (a-к). В консоли должно высветиться сообщение: «Точка [(x; y)] принадлежит фигуре [г]». */
namespace Task_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string grafick;
            bool inGrafick = false;

            Console.WriteLine("Please,write coordinate X");
            x = double.Parse(Console.ReadLine());//todo pn может возникнуть исключение
            Console.WriteLine("Please,write coordinate Y");
            y = double.Parse(Console.ReadLine());//todo pn может возникнуть исключение
			Console.WriteLine("Please,write type of figure");
            grafick = Console.ReadLine();
            double r;
            r = Math.Sqrt((x * x) + (y * y));
            switch (grafick)
            {
                case "a":
                    if (r <= 1)//todo pn бизнес-логику выносим в отдельные методы-классы. В методе Main должна быть только обработка пользовательских действий.
                    {
                       inGrafick = true;
                    }

                    break;
                case "b":
                    if ((r <= 1) && (r >= 0.5))
                    {
                        inGrafick = true;
                    }

                    break;
                case "c":
                    if ((Math.Abs(x) <= 1) && (Math.Abs(y) <= 1))
                    {
                       inGrafick = true;
                    }

                    break;
                case "d":
                    if ((y >= Math.Abs(x) - 1) && (y <= (-1 * Math.Abs(x)) + 1))
                    {
                        inGrafick = true;
                    }

                    break;
                case "e":
                    if ((y >= (2 * Math.Abs(x)) - 1) && (y <= (-2 * Math.Abs(x)) + 1))
                    {
                        inGrafick = true;
                    }

                    break;
                case "f":
                    if (x >= 0)
                    {
                        if (r <= 1)
                        {
                            inGrafick = true;
                        }
                    }
                    else
                        if ((y <= 0.5 * x + 2) && (y >= -0.5 * x + 2))
                    {
                        inGrafick = true;
                    }

                    break;
                case "g":
                    if ((y <= (-2 * Math.Abs(x)) + 2) && (y >= -1))
                    {
                        inGrafick = true;
                    }

                    break;
                case "h":
                    if ((y <= Math.Abs(x)) && (y >= -2) && (Math.Abs(x) <= 1))
                    {
                        inGrafick = true;
                    }

                    break;
                case "i":
                    if (y <= 0)
                    {
                        if ((y <= ((2 / 3) * x) + (1 / 3)) && (y >= ((1 / 3) * x) - (1 / 3)))
                        {
                            inGrafick = true;
                        }
                    }
                    else
                    {
                        if ((y <= 2 / 3 * x + 1 / 3) && (y <= -1 * x))
                        {
                            inGrafick = true;
                        }
                    }

                    break;
                case "к":
                    if ((y >= 1) || (y >= Math.Abs(x)))
                    {
                        inGrafick = true;
                    }

                    break;
                default:
                    Console.WriteLine("Error, choosen figure {0} is not specified, please choose from (a-i)", grafick);
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                    }

            if (inGrafick)
            {
                Console.WriteLine("«The point ({0};{1}) lies on the figure {2}».", x, y, grafick);
            }
            else
            {
                Console.WriteLine("The point ({0};{1}) is not lie on the figure {2}.", x, y, grafick);
            }

            Console.ReadLine();
        }
    }
}