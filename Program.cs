using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Mlek("cat");
            Animals copycat = (Animals)cat.Clone();
            Animals dog = new Mlek();
            Animals pinguine = new Bird("a");
            Animals pinguine1 = new Bird("b");
            Animals pinguine2 = new Bird("c");
            copycat.Name = "da";
            copycat.Display();

            Zoo zoo = new Zoo();
            zoo.Show();

            Animals[] animals = new Animals[] { pinguine, pinguine1, pinguine2};

            Person p1 = new Person { Name = "Bill", Age = 34 };
            Person p2 = new Person { Name = "Tom", Age = 23 };
            Person p3 = new Person { Name = "Alice", Age = 21 };

            Person[] people = new Person[] { p1, p2, p3 };
            Array.Sort(people);

            foreach (Person p in people)
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }

            Array.Sort(people, animals);

            Console.ReadKey();
        }
    }

    public abstract class Animals : ICloneable //интерфейс IClonable
    {
        public string Name { get; set; }

        string[] animals = new string[] { "cat", "cow", "dog" };
        public abstract void Display(); //абстрактный метод
        public object Clone() //определение метода интерфейса
        {
            Console.WriteLine("Работа интерфейса 'IClone'");
            return this.MemberwiseClone(); //клонирование объекта
        }
    }

    class Mlek : Animals //наследуемый класс
    {
        public string Name { get; set; }

        public Mlek() //конструктор по умолчанию
        {
            Name = string.Empty;
        }

        public Mlek(string name) //конструктор с параметром
        {
            Name = name;
        }

        public override void Display() //переопределенный абстрактный метод
        {
            Console.WriteLine("Имя животного: " + Name);
        }

    }
    class Parnokop : Animals //наследуемый класс
    {
        public string Name { get; set; }

        public Parnokop() //конструктор по умолчанию
        {
            Name = string.Empty;
        }
        public Parnokop(string name) //конструктор с параметром
        {
            Name = name;
        }
        public override void Display() //переопределенный абстрактный метод
        {
            Console.WriteLine("Имя животного: " + Name);
        }

    }
    class Bird : Animals //наследуемый класс
    {
        public string Name { get; set; }
        public Bird() //конструктор по умолчанию
        {
            Name = string.Empty;
        }
        public Bird(string name) //конструктор с параметром
        {
            Name = name;
        }
        public override void Display() //переопределенный абстрактный метод
        {
            Console.WriteLine("Имя животного: " + Name);
        }
    }

    class Zoo : Ienumerable //коллекция объектов дочерних экземпляров класса Animals
    {
        public string Name { get; set; }
        List<Animals> objlist = new List<Animals>() { new Mlek("Cat"), new Parnokop("Cow"), new Bird("Pinguine"), new Mlek() };
        public void Show() //метод интерфейса IEnumerable
        {
            Console.WriteLine("Работа интерфейса 'IEnumerable'");
            foreach (Animals i in objlist)
            {
                Console.WriteLine(i);
            }
        }
    }

    public interface Ienumerable //публичный интерфейс IEnumerable
    {
        public void Show();
    }

    class Person : IComparable //класс для демонстрации работы интерфейса IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object o) //метод интерфейса IComparable
        {
            Console.WriteLine("Работа интерфейса 'IComparable'");
            Person p = o as Person;
            if (p != null) //проверка на сравнение экземляров класса
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта"); //бросаем исключение при отсутствии экземляра
        }
    }

    class PeopleComparer : IComparer<Person> //класс для демонстрации работы интерфейса IComparer
    {
        public int Compare(Person p1, Person p2) //метод интерфейса ICompare
        {
            Console.WriteLine("Работа интерфейса 'ICompare'");
            if (p1.Name.Length > p2.Name.Length) //сравнение длины имен объектов
                return 1;
            else if (p1.Name.Length < p2.Name.Length) 
                return -1;
            else
                return 0;
        }
    }
}
