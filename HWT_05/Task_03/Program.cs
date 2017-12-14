namespace Task_03
{
    using System;
   
    public class User
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public int Dayofbirth;
        public int Monthofbirth;
        public int Yearofbirth;

        public int Useryears(int year)
        {            
            return year - this.Yearofbirth;//todo pn некорректная логика
        }        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var myuser = new User();
            var date = new DateTime();
            date = DateTime.Today;
            while (true)
            {           
                    Console.WriteLine("Please write your name");                                  
                    myuser.Name = Console.ReadLine();          
                    Console.WriteLine("Please write your surname");
                     myuser.Surname = Console.ReadLine();
                    Console.WriteLine("Please write your patronymic");
                    myuser.Patronymic = Console.ReadLine();
                Console.WriteLine("Please write your day of birth");
                while (true)
                     {                         
                         if (int.TryParse(Console.ReadLine(), out myuser.Dayofbirth))
                        {
                        if ((myuser.Dayofbirth > 31) || (myuser.Dayofbirth < 0))
                        {
                            Console.WriteLine("Error.Please write correct value of day");
                        }
                            else
                        {
                            break;
                            }
                        }
                        else
                        {
                        Console.WriteLine("Error.Please write correct value of day");
                         }
                      }

                Console.WriteLine("Please write your month of birth");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out myuser.Monthofbirth))
                    {
                        if ((myuser.Monthofbirth > 12) || (myuser.Monthofbirth < 0))
                        {
                            Console.WriteLine("Error.Please write correct value of Month");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of Month");
                    }
                }

                Console.WriteLine("Please write your year of birth");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out myuser.Yearofbirth))
                    {
                        if ((myuser.Yearofbirth > date.Year) || (myuser.Yearofbirth < 1920))
                        {
                            Console.WriteLine("Error.Please write correct value of Year");
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error.Please write correct value of Year");
                    }
                }

                Console.WriteLine("User information: {0} {1} {2}", myuser.Name, myuser.Surname, myuser.Patronymic);
                Console.WriteLine("Date of birth: {0}.{1}.{2}", myuser.Dayofbirth, myuser.Monthofbirth, myuser.Yearofbirth);
                var useryears = myuser.Useryears(date.Year);
                Console.WriteLine("Age : {0}", useryears);
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
