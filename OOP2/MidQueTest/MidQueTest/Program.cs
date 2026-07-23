using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MidQueTest
{
    internal class Program
    {


        public class Employee
    {
        private String Id, Name;
        private int Sal;
        public MidDate Date;

        public string id
        {
            set;
            get;
        }
        public string name
        {
            set;
            get;
        }
        public int sal
        {
            set;
            get;
        }
        public MidDate date
        {
            set;
            get;
        }
        public Employee(String Id, String Name, int Sal, MidDate Date)
        {
            this.id = Id;
            this.name = Name;
            this.sal = Sal;
            this.date = Date;
        }
        public virtual void ShowInfo()
        {

        }
        public virtual void GrossIncome()
        {

        }


    }
    public class FullTime : Employee
    {
        public int bonus;
        public FullTime(String Id, String Name, int Sal, MidDate Date, int bonus) : base(Id, Name, Sal, Date)
        {
            this.bonus = sal / 2;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID:{id},NAME:{name},SAL:{sal},JOINING DATE:{date.print()},BONUS:{bonus}");
        }
        public override void GrossIncome()
        {
            int TotalIncome = (sal * 12) + (2 * bonus);
            Console.WriteLine($"TOTAL INCOME = {TotalIncome}");
        }
    }
    public class PartTime : Employee
    {
        public int commission;
        public PartTime(String Id, String Name, int Sal, MidDate Date, int commission) : base(Id, Name, Sal, Date)
        {
            this.commission = commission;

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"ID:{id},NAME:{name},SAL:{sal},JOINING DATE:{date.print()},COMMISSION:{commission}");
        }
        public override void GrossIncome()
        {
            int TotalIncome = (sal) + (commission);
            Console.WriteLine($"TOTAL INCOME = {TotalIncome}");
        }
    }
    public class MidDate
    {
        public int Day, Month, Year;

        public int day
        {
            set;
            get;
        }
        public int month
        {
            set;
            get;
        }
        public int year
        {
            set;
            get;
        }
        public MidDate(int Day, int Month, int Year)
        {
            this.day = Day;
            this.month = Month;
            this.year = Year;


        }
        public String print()
        {
            return $"{Day},{Month},{Year}";
        }


    }
    static void Main(string[] args)
    {
        Employee[] emp = new Employee[2];
        emp[0] = new FullTime("E-001", "Saf", 30000, new MidDate(12, 09, 2013), 15000);
        emp[1] = new PartTime("E-002", "KavSur", 12000, new MidDate(23, 07, 2019), 1300);

        foreach (Employee e in emp)
        {
            e.ShowInfo();
            e.GrossIncome();
        }
    }
}
    
}











    

