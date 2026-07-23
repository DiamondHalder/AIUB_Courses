using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MIDTASK_2
{
    internal class Program
    {
        public class Employee
        {
            private string id, name;
            private int sal;
            public Mydate date;

            public string Id
            {
                set;
                get;
            }
            public string Name
            {
                set;
                get;
            }
            public Mydate Date
            {
                set;
                get;
            }
            public int Sal
            {
                set;
                get;
            }
            

            public Employee(string id, string name, int sal, Mydate date)
            {
                this.Id = id;
                this.Name = name;
                this.Sal = sal;
                this.Date = date;
                

            }

            public virtual void Showinfo()
            {
               
            }
            public virtual void Grossincome()
            {
               
            }
        }
        public class FullTime : Employee
        {
            int bonus;
            public FullTime(string id, string name, int sal, Mydate date,int bonus) : base(id, name, sal, date) 
                {
                  this.bonus=bonus;
                  bonus = sal/2;
                }
            public override void Showinfo()
             {
                Console.WriteLine("FULLTIME JOB EMPLOYEE");
                Console.WriteLine($"ID = {Id}, NAME = {Name}, DATE = {Date.printdate()}, SAL = {Sal}, BONUS = {bonus}");
             }
            public override void Grossincome()
                 {
                int TotalIncome = (Sal * 12) + (bonus * 2);
                     Console.WriteLine($"TOTAL INCOME ={TotalIncome} ");
                Console.WriteLine();
            }
                   

        }
    public class PartTime : Employee
        {
            int bonus;
            public PartTime(string id, string name, int sal, Mydate date, int bonus) : base(id, name, sal, date) 
                {
                    this.bonus=bonus;
                  //bonus = sal/2;
                }
            public override void Showinfo()
             {
                Console.WriteLine("PARTTIME JOB EMPLOYEE");
                Console.WriteLine($"ID = {Id}, NAME = {Name}, DATE = {Date.printdate()}, SAL = {Sal}, BONUS = {bonus}");
             }
            public override void Grossincome()
                 {
                    int TotalIncome = (Sal) + (bonus);
                     Console.WriteLine($"TOTAL INCOME ={TotalIncome} ");
                 }

        }

        public class Mydate
        {
            int Day,  Month, Year;


            public Mydate(int Day, int Month, int Year)
            {
                this.Day = Day;
                this.Month = Month;
                this.Year = Year;
            }
            public string printdate()
            {
                return $"{Day},{Month},{Year}";
            }
        }
        static void Main(string[] args)
        {
             Employee[] emp = new Employee[2];
             emp[0] = new FullTime("E-001","saef",30000,new Mydate(12,09,2013),1500);
             emp[1] = new PartTime("E-002","kawsur",12000,new Mydate(23,07,2019),1300);
             foreach (Employee e in emp)
             {
                 e.Showinfo();
                 e.Grossincome();
             }
           

            Console.ReadKey();


        }
    }
}
