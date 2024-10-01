using NPOI.XSSF.Streaming.Values;
using Org.BouncyCastle.Crypto.Prng.Drbg;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pradeep_1
{
    public interface IAnimal
    {
        public void MakeSound();
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog barking");
        }
    }
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("meow");
        }
    }
    public class Program41
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();
            Dog dog = new Dog();
            IAnimal animal1 = new Cat();
            dog.MakeSound();
            MakeAnimalSound(animal1);
            IAnimal animal2 = new Dog();
            MakeAnimalSound(animal2);


        }
        public static void MakeAnimalSound(IAnimal animal)
        {
            animal.MakeSound();
        }
    }
}
