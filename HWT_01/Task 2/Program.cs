/* Дано действительное число h.Выяснить, имеет ли уравнение a*x^2+b*x+c=0 действительные корни
Пграмма должна выводить пользователю промежуточные вычисления
(например, a, b, c и дискриминант (если вычисляли при помощи него) и корни (если есть)). */
namespace Task_02
{
    using System;
    using System.Collections.Generic;//todo pn неиспользуемые using удаляем
	using System.Linq;//todo pn неиспользуемые using удаляем
	using System.Text;//todo pn неиспользуемые using удаляем
	using System.Threading.Tasks;//todo pn неиспользуемые using удаляем

	public class Program
    {
        static void Main(string[] args)
        {
            double h, a, b, c, discrim, x1, x2, temp1, temp2;//todo pn бизнес-логику выносим в отдельные методы-классы. В методе Main должна быть только обработка пользовательских действий.
			Console.WriteLine("Please, write number h ");
            h = double.Parse(Console.ReadLine());//todo pn может возникнуть исключение
			temp1 = Math.Abs(Math.Sin(8 * h) + 17);
            temp2 = 1 - (Math.Sin(4 * h) * Math.Cos(Math.Pow(h, 2) + 18));
            a = Math.Sqrt(temp1 / (temp2 * temp2));
            temp1 = Math.Tan(a * Math.Pow(h, 2));
            temp2 = Math.Sin(a * h);
            b = 1 - Math.Sqrt(3 / (3 + Math.Abs(temp1 - temp2)));
            temp1 = a * Math.Pow(h, 2) * Math.Sin(b * h);
            temp2 = b * Math.Pow(h, 3) * Math.Cos(a * h);
            c = temp1 + temp2;
            discrim = Math.Pow(b, 2) - (4 * a * c);
            if (discrim < 0)
            {
                Console.WriteLine("Уравнение не имеет действительных корней");
            }
            else if (discrim > 0)
            {
                x1 = (-b + Math.Sqrt(discrim)) / (2 * a);
                x2 = (-b - Math.Sqrt(discrim)) / (2 * a);
                Console.WriteLine("The equation has 2 roots");
                Console.WriteLine("x1={0},x2={1}", x1, x2);
                }
            else
            {
                x1 = -1 * b / 2 * a;
                Console.WriteLine("The equation has 1 root");
                Console.WriteLine("x={0}", x1);
            }

            Console.WriteLine("Number а={0}, number b={1}, number c ={2}", a, b, c);
            Console.WriteLine("discriminant equal to {0}", discrim);
            Console.ReadLine();
        }
    }
}