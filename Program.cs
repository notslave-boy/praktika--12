using System;
using System.Collections.Generic;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Mlek("cat");
            Animals cat2 = (Animals)cat.Clone();
            cat2.Display();
            Console.ReadKey();
        }
    }

    public abstract class Animals : ICloneable
    {
        public string Name { get; set; }
        public abstract void Display();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Mlek : Animals //наследуемый класс
    {
        public string _name { get; set; }

        public Mlek(string name)
        {
            _name = name;
        }

        public override void Display()
        {
            Console.WriteLine("Имя животного: " + _name);
        }

    }
    class Parnokop : Animals //наследуемый класс
    {
        public string _name { get; set; }
        public Parnokop(string name)
        {
            _name = name;
        }
        public override void Display()
        {
            Console.WriteLine("Имя животного: " + _name);
        }

    }
    class Bird : Animals //наследуемый класс
    {
        public string _name { get; set; }
        public Bird(string name)
        {
            _name = name;
        }
        public override void Display()
        {
            Console.WriteLine("Имя животного: " + _name);
        }
    }

    class Zoo //коллекция объектов дочерних экземпляров класса Animals
    {
        List<Animals> objlist = new List<Animals>() { new Mlek("Cat"), new Parnokop("Cow"), new Bird("Pinguine") };
    }

    

}
