using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3
{
    internal class Program
    {
        

public class Contact
    {
        private string personName;
        private string personID;
        private int age;
        private string mobileNumber;
        private char gender;

        // Properties
        public string PersonName
        {
            get { return personName; }
            set { personName = value; }
        }

        public string PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        // Constructors
        public Contact()
        {
            Console.WriteLine("Contact object created with default constructor.");
        }

        public Contact(string personName, string personID, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personID = personID;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
            Console.WriteLine("Contact object created with parameterized constructor.");
        }

        // Member functions
        public void showPersonInfo()
        {
            Console.WriteLine($"Name: {PersonName}, \nID: {PersonID}, \nAge: {Age}, \nMobile: {MobileNumber}, \nGender: {Gender}");
        }

        public void detectMobileOperator()
        {
            if (mobileNumber.StartsWith("017"))
            {
                Console.WriteLine("Mobile Operator: GP");
            }
            else if (mobileNumber.StartsWith("018"))
            {
                Console.WriteLine("Mobile Operator: Robi");
            }
            else if (mobileNumber.StartsWith("019"))
            {
                Console.WriteLine("Mobile Operator: Banglalink");
            }
            else if (mobileNumber.StartsWith("016"))
            {
                Console.WriteLine("Mobile Operator: Airtel");
            }
            else
            {
                Console.WriteLine("Unknown Mobile Operator");
            }
        }
    }

    static void Main(string[] args)
        {
            Contact contact = new Contact(); 
            Contact contact1 = new Contact("abc","3434",23,"0161412714",'M');

            contact1.showPersonInfo();
            contact1.detectMobileOperator();
        }
    }
}
