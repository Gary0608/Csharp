using System;
using MyNamespace;

var p1 = new MyNamespace.Person("Gary", "Huang", new DateOnly(2000, 6, 8));

var p2 = new MyNamespace.Person("Mandy", "Huang", new DateOnly(2000, 6, 25));

List<MyNamespace.Person> people = [p1, p2];

p1.Pets.Add(new Cat("Blacky"));
p1.Pets.Add(new Cat("Siroyi"));

p2.Pets.Add(new Dog("Luffy"));

Console.WriteLine(people.Count);

foreach (var p in people)
{
    Console.WriteLine($"{p}");

    foreach (var pet in p.Pets)
    {
        Console.WriteLine($"    {pet}");
    }
}

namespace MyNamespace
{
    public class Person(string firstname, string lastname, DateOnly birthday)
    {
        public string First { get; } = firstname;
        public string Last { get; } = lastname;
        public DateOnly Birthday { get; } = birthday;

        public List<Pet> Pets { get; } = new();

        public override string ToString()
        {
            return $"{First} {Last}";
        }
    }

    public abstract class Pet(string firstname)
    {
        public string First { get; } = firstname;
        public abstract string MakeNoise();

        public override string ToString()
        {
            return $"{First} and I am {GetType().Name} and I {MakeNoise()}";
        }
    }

    public class Cat(string firstname) : Pet(firstname)
    {
        public override string MakeNoise() => "meow";
    }

    public class Dog(string firstname) : Pet(firstname)
    {
        public override string MakeNoise() => "bark";
    }
}