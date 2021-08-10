using System;
namespace SolidPrinciples.LSP
{
        interface IRun
        {
            void Run();
        }

        interface ISwim
        {
            void Swim();
        }

        abstract class Animal
        {
            public abstract void Breed();
        }

        class Dog : Animal, IRun
        {
            public override void Breed()
            {
                Console.WriteLine("Dog is breeding");

            }

            public void Run()
            {
                Console.WriteLine("Dog is running");
            }
        }

        class Fish : Animal, ISwim
        {
            public override void Breed()
            {
                Console.WriteLine("Fish is breeding");

            }

            public void Swim()
            {
                Console.WriteLine("Fish is swimming");
            }
        }
}
