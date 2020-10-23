using System;
using System.Collections.Generic;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    abstract class Animals  //базовый абстрактный класс
    {
        public string Name { get; set; }
        
    }

    class Mlek : Animals //наследуемый класс
    {
        private string _name;
        public Mlek(string name)
        {
            _name = name;
        }

    }
    class Parnokop : Animals //наследуемый класс
    {
        private string _name;
        public Parnokop(string name)
        {
            _name = name;
        }

    }
    class Bird : Animals //наследуемый класс
    {
        private string _name;
        public Bird(string name)
        {
            _name = name;
        }
    }

    class Zoo //коллекция объектов дочерних экземпляров класса Animals
    {
        List<Animals> objlist = new List<Animals>() { new Mlek("Cat"), new Parnokop("Cow"), new Bird("Pinguine") };       
    }

}
