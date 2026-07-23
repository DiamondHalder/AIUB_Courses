using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketerBollerBatsman
{
    internal class Program
    {
        public class Cricketer
        {
            private string name, id;
            private int age;
            private date Date;

            public string Name
            { get; set; }
            public string Id
            { get; set; }
            public int Age
            { get; set; }
            public date Date1
            { get; set; }
            public Cricketer()
            { Console.WriteLine("{0},{1}qeidjo"); }
            public Cricketer(string name, string id, int age, date Date)
            {
                Name = name;
                Id = id;
                Age = age;
                Date1 = Date;
               
            }
            public virtual void ShowInfo()
            { }

        }
        public class Batsman : Cricketer
        {
            private int run;

            public int Run
            {
                get; set;
            }

            public Batsman() { Console.WriteLine("batsman constructor called"); }
            public Batsman(string name, string id, int age, int run, date Date) : base(name, id, age,Date)
            {
                Run = run;
            }
            public override void ShowInfo()
            {
                Console.WriteLine($"Name:{Name},  Id:{Id},  Age:{Age},  Run:{Run},  Joining Date{Date1.printdate()}");
            }

        }
        public class Boller : Cricketer
        {
            private int wicket;

            public int Wicket
            {
                get; set;
            }

            public Boller() { Console.WriteLine("boller constructor called"); }
            public Boller(string name, string id, int age, int wicket, date Date) : base(name, id, age, Date)
            {
                Wicket = wicket;
            }
            public override void ShowInfo()
            {
                Console.WriteLine($"Name:{Name}, Id:{Id}, Age:{Age}, Wicket:{Wicket}, Joining Date{Date1.printdate()}");
            }

        }

        public class date
        {
            int day, month, year;
            public date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            public string printdate()
            {
                return $"{day}.{month}. {year}" ;
            }
        }
        static void Main(string[] args)
        {
            //Cricketer cricketer = new Cricketer();
            //Batsman batsman = new Batsman();
            Batsman batsman1 = new Batsman("bat","124ed",24,5000,new date(10,12,2024));

            Boller bollar = new Boller();
            Boller bollar1 = new Boller("ball","1fewf33d",25,34,new date(12,01,2024));

            batsman1.ShowInfo();
            bollar1.ShowInfo();
        }
    }
}

