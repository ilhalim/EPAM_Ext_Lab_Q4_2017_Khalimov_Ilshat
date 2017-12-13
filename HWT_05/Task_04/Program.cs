namespace Task_04
{
    using System;

    public class MyString
    {
        public int Numberofchars;
        public char[] Mystring = new char[1000];

        public static void Add(MyString s1, MyString s2, MyString s3)
        {
            s3.Numberofchars = s1.Mylenght() + s2.Mylenght();
            for (int i = 0; i < s1.Mylenght(); i++)
            {
                s3.Mystring[i] = s1.Mystring[i];
            }

            for (int i = s1.Mylenght(); i < s1.Mylenght() + s2.Mylenght(); i++)
            {
                s3.Mystring[i] = s2.Mystring[i - s1.Mylenght()];
            }
        }

        public static void RemoveFromMySring(MyString s1, char ch)
        {
            for (int i = 0; i < s1.Mylenght(); i++)
            {
                if (s1.Mystring[i] == ch)
                {
                    s1.Mystring[i] = ' ';
                }
            }
        }

        public static void MyStringToUpper(MyString s1)
        {
            for (int i = 0; i < s1.Mylenght(); i++)
            {
                s1.Mystring[i] = char.ToUpper(s1.Mystring[i]);
            }
        }

        public static void MyStringToLower(MyString s1)
        {
            for (int i = 0; i < s1.Mylenght(); i++)
            {
                s1.Mystring[i] = char.ToLower(s1.Mystring[i]);
            }
        }

        public static void CreateMyString(int numberofchars, char[] mystring)
        {
           for (int i = 0; i < numberofchars; i++)
            {
                mystring[i] = char.Parse(Console.ReadLine());
            }
        }

        public static void OutputMyString(MyString s1)
        {
            for (int i = 0; i < s1.Numberofchars; i++)
            {
                Console.Write(s1.Mystring[i]);
            }

            Console.WriteLine();
        }

        public int Mylenght()
        {
            return this.Numberofchars;
        }

        public bool Equals(MyString s1)
        {            
            if (s1.Mylenght() == this.Mylenght())
            {
                for (int i = 0; i < s1.Mylenght(); i++)
                {
                   if (s1.Mystring[i] != this.Mystring[i])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }  
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var s1 = new MyString();
            var s2 = new MyString();
            var s3 = new MyString();
            while (true)
            {
                Console.WriteLine("Plese write number of symvols in string s1");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out s1.Numberofchars))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value");
                    }
                }

                Console.WriteLine("Please write sring s1 the item using enter");
                MyString.CreateMyString(s1.Numberofchars, s1.Mystring);
                Console.WriteLine("Please write number of symvols in string s2 ");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out s2.Numberofchars))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value");
                    }
                }

                Console.WriteLine("Please write string s2 the item using enter");
                MyString.CreateMyString(s2.Numberofchars, s2.Mystring);
                Console.WriteLine("New string after adding s1 and s2");
                MyString.Add(s1, s2, s3);
                MyString.OutputMyString(s3);
                Console.WriteLine("String s3after Upper their symbols");
                MyString.MyStringToUpper(s3);
                MyString.OutputMyString(s3);
                Console.WriteLine("String s3 after Lower their symbols");
                MyString.MyStringToLower(s3);
                MyString.OutputMyString(s3);
                Console.WriteLine("Please write symbol to remove from s3");
                var ch  = char.Parse(Console.ReadLine());                   
                MyString.RemoveFromMySring(s3, ch);
                MyString.OutputMyString(s3);
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
