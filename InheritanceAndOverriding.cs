using System;

class Animal
{

 public virtual void MakeSound()
 {
    Console.WriteLine("Some generic sound");
 }
}


class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}


class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class AnimalDemo
{
    static void Main()
    {
        Console.WriteLine("Inheritance and Mehod Overriding");

        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

       genericAnimal.MakeSound ();
       myDog.MakeSound();
       myCat.MakeSound();

    }
}