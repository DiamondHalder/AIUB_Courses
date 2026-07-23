using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Animal
{
    internal class Program
    {
        abstract class Animal
        {
            protected string name;

            public abstract void MakeSound();

            public void SetName(string name)
            {
                this.name = name;
            }

            

            public virtual void Eat()
            {
                Console.WriteLine($"{name} is eating.");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine($"{name} says: Woof Woof!");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine($"{name} says: Meow Meow!");
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName("Buddy");
            dog.MakeSound();
            dog.Eat();

            Cat cat = new Cat();
            cat.SetName("Whiskers");
            cat.MakeSound();
            cat.Eat();
        }
    }
}
