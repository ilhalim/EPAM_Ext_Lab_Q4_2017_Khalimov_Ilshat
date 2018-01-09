namespace Task_02
{
    using System;

    public class Program       
    {
        public delegate void Hello(string name, int time);

        public delegate void GoodBye(string name);

        public static void Parting(Person person, GoodBye bye, int time)
        {
            if (bye != null)
            {
                bye(person.Name);
            }
        }

        public static void Creeting(Person person, Hello greet, int time)
        {
            if (greet != null)
            {
                greet(person.Name, time);
            }
        }

        public static void Percon_Came(Person person, int time)
        {
            Console.WriteLine("{0}  came at {1}", person.Name, time);         
        }

        public static void Percon_Left(Person person, int time)
        {
            Console.WriteLine("{0}  left at {1}", person.Name, time);
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Person john = new Person { Name = "John" };
                Person bill = new Person { Name = "Bill" };
                Person mary = new Person { Name = "Mary" };
                Person ann = new Person { Name = "Ann" };
                Hello greetByJohn = new Hello(john.Greet);
                Hello greetByBill = new Hello(bill.Greet);
                Hello greetByMary = new Hello(mary.Greet);
                Hello greetByAnn = new Hello(ann.Greet);
                Hello greetByAll = null;
                GoodBye goodByByJohn = new GoodBye(john.Leave);
                GoodBye goodByeByBill = new GoodBye(bill.Leave);
                GoodBye goodByeByMary = new GoodBye(mary.Leave);
                GoodBye goodByeByAnn = new GoodBye(ann.Leave);
                GoodBye goodByeByAll = null;                
                john.Came += Percon_Came;
                john.OnCame(9);
                Creeting(john, greetByAll, 9);
                greetByAll += greetByJohn;
                goodByeByAll += goodByByJohn;
                bill.Came += Percon_Came;
                bill.OnCame(10);
                Creeting(bill, greetByAll, 10);
                greetByAll += greetByBill;
                goodByeByAll += goodByeByBill;
                john.Left += Percon_Left;
                john.Leaver(14);
                greetByAll -= greetByJohn;
                goodByeByAll -= goodByByJohn;
                Parting(john, goodByeByAll, 14);
                ann.Came += Percon_Came;
                ann.OnCame(15);
                Creeting(ann, greetByAll, 15);
                greetByAll += greetByAnn;
                goodByeByAll += goodByeByAnn;
                mary.Came += Percon_Came;
                mary.OnCame(18);
                Creeting(mary, greetByAll, 18);
                greetByAll += greetByMary;
                goodByeByAll += goodByeByMary;
                ann.Left += Percon_Left;
                ann.Leaver(21);
                greetByAll -= greetByAnn;
                goodByeByAll -= goodByeByAnn;
                Parting(ann, goodByeByAll, 21);
                bill.Left += Percon_Left;
                bill.Leaver(22);
                greetByAll -= greetByBill;
                goodByeByAll -= goodByeByBill;
                Parting(bill, goodByeByAll, 22);
                mary.Left += Percon_Left;
                mary.Leaver(23);
                greetByAll -= greetByMary;
                goodByeByAll -= goodByeByMary;
                Parting(mary, goodByeByAll, 23);
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
