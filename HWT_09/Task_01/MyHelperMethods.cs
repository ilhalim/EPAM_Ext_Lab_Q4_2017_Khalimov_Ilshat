namespace Task_01
{
    using System;

    public static class MyHelperMethods
    {
        public static void MyWrite(string s)//todo pn неправильная реализация разделения UI и BL. Нужно определять интерфейс. Всё это нужно для дальнейшего применения инверсии зависимостей через IoC контейнер.
        {
            Console.WriteLine(s);
        }

        public static int SumofArray(this int[] number)
        {
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            return sum;
        }
    }
}
