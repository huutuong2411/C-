﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat160 = new Cat();
            cat160.eat();
            cat160.makeSound();
            cat160.run();
            Bird bird160 = new Bird();
            bird160.eat();
            bird160.makeSound();
            bird160.fly();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Thuc an");
        }
        public virtual void makeSound()
        {
            Console.WriteLine("");
        }
    }
    class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("Meo chay...");

        }
        public override void eat()
        {
            Console.WriteLine("Meo an thuc an...");
        }
        public override void makeSound()
        {
            Console.WriteLine("Meo keu Meo...Meo...");
        }
    }
    class Bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("Chim bay...");

        }
        public override void eat()
        {
            Console.WriteLine("Chim an sau");
        }
        public override void makeSound()
        {
            Console.WriteLine("Chim an con trung");
        }
    }
}
