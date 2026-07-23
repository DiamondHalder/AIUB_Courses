using System;

namespace MIDTASK_2
{
    internal class Program
    {
        public class Employee
        {
            public string Id;
            public string Name;
            public int Sal;
            public int Bonus;
            public Mydate Date;

            public Employee(string Id, string Name, int Sal, Mydate Date, int Bonus)
            {
                this.Id = Id;
                this.Name = Name;
                this.Sal = Sal;
                this.Date = Date;
                this.Bonus = Bonus;
            }

            public virtual void Showinfo()
            {
                Console.WriteLine($"ID = {Id}, NAME = {Name}, DATE = {Date.ToString()}, SAL = {Sal}, BONUS = {Bonus}");
            }

            public virtual void Grossincome()
            {
                int TotalIncome = (Sal * 12) + (Bonus * 2);
                Console.WriteLine($"TOTAL INCOME = {TotalIncome}");
            }
        }

        public class FullTime : Employee
        {
            public FullTime(string id, string name, int sal, Mydate date) : base(id, name, sal, date, sal / 2)
            {
            }

            public override void Showinfo()
            {
                Console.WriteLine("FULLTIME JOB EMPLOYEE");
                base.Showinfo();
            }

            public override void Grossincome()
            {
                int TotalIncome = (Sal * 12) + (Bonus * 2);
                Console.WriteLine($"TOTAL INCOME = {TotalIncome}");
                Console.WriteLine();
            }
        }

        public class PartTime : Employee
        {
            public PartTime(string id, string name, int sal, Mydate date, int bonus) : base(id, name, sal, date, bonus)
            {
            }

            public override void Showinfo()
            {
                Console.WriteLine("PARTTIME JOB EMPLOYEE");
                base.Showinfo();
            }

            public override void Grossincome()
            {
                int TotalIncome = Sal + Bonus;
                Console.WriteLine($"TOTAL INCOME = {TotalIncome}");
            }
        }

        public class Mydate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public Mydate(int day, int month, int year)
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }

            public override string ToString()
            {
                return $"{Day:D2}/{Month:D2}/{Year}";
            }
        }

        static void main(string[] args)
        {
            Employee[] emp = new Employee[2];
            emp[0] = new FullTime("E-001", "Saef", 30000, new Mydate(12, 09, 2013));
            emp[1] = new PartTime("E-002", "Kawsur", 12000, new Mydate(23, 07, 2019), 1300);

            foreach (Employee e in emp)
            {
                e.Showinfo();
                e.Grossincome();
            }

            Console.ReadKey();
        }
    }
}