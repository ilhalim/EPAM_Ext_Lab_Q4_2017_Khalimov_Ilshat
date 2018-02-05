namespace Task_02
{
    using System;

    public class Person
    {
        public delegate void EventHandler(Person person, int time);

        public event EventHandler Came;

        public event EventHandler Left;

        public string Name { get; set; }              

        public void Leaver(int time)
        {
            if (this.Left != null)
            {
                this.Left(this, time);
            }
        }

        public void OnCame(int time)
        {
            if (this.Came != null)
            {
                this.Came(this, time);
            }
        }
        
        public void Greet(string anotherPerson, int time)
        {
            string greetontime;
            if (time <= 12)
            {
                greetontime = "Good morning"; //todo pn хардкод
            }
            else if (time <= 17)
            {
                greetontime = "Good day"; //todo pn хардкод
			}
            else
            {
                greetontime = "Good evening"; //todo pn хардкод
			}

            Console.WriteLine("'{0}, {1}!',{2} said.", greetontime, anotherPerson, this.Name); //todo pn хардкод
		}

        public void Leave(string anotherPerson)
        {
            Console.WriteLine("'Good bye, {0}!',{1} said.", anotherPerson, this.Name); //todo pn хардкод
		}
    }
}