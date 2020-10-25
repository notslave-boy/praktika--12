using System;
using System.Collections.Generic;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Mlek("cat");
            Animals copycat = (Animals)cat.Clone();
            copycat.Display();

            Zoo zoo = new Zoo();
            zoo.Show();
            Console.ReadKey();

            
        }
    }
       
    public abstract class Animals : ICloneable
    {
        public string Name { get; set; }

        string[] animals = new string[] { "cat", "cow", "dog" };
        public abstract void Display();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }



    class Mlek : Animals //наследуемый класс
    {
        public string Name { get; set; }

        public Mlek(string name)
        {
            Name = name;
        }

        public override void Display()
        {
            Console.WriteLine("Имя животного: " + Name);
        }

    }
    class Parnokop : Animals //наследуемый класс
    {
        public string Name { get; set; }
        public Parnokop(string name)
        {
            Name = name;
        }
        public override void Display()
        {
            Console.WriteLine("Имя животного: " + Name);
        }

    }
    class Bird : Animals //наследуемый класс
    {
        public string Name { get; set; }
        public Bird(string name)
        {
            Name = name;
        }
        public override void Display()
        {
            Console.WriteLine("Имя животного: " + Name);
        }
    }

    class Zoo : Ienumerable //коллекция объектов дочерних экземпляров класса Animals
    {
        List<Animals> objlist = new List<Animals>() { new Mlek("Cat"), new Parnokop("Cow"), new Bird("Pinguine") };

        public void Show()
        {
            foreach(Animals i in objlist)
            {
                Console.WriteLine(i);
            }
        }
    }

    public interface Ienumerable
    {
        public void Show();
    }

    

    

    

}
