// See https://aka.ms/new-console-template for more information

using System;
//Person person = new Person();
//Person person1 = new Person("Vasya", 25);
//Person person2 = new Person("Nina", 28);
//Person person3 = new Person("Ivan", 45);
////Console.WriteLine("класс Person с полями Name, Age");
//Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
//Console.WriteLine($"Имя: {person1.Name}, Возраст: {person1.Age}");
//Console.WriteLine($"Имя: {person2.Name}, Возраст: {person2.Age}");
//Console.WriteLine($"Имя: {person3.Name}, Возраст: {person3.Age}");
//Console.ReadLine();



////class Person
////{
////    public string Name = "Vasya";
////    public int Age = 29;
////}


//class Person
//{
//    public string Name;
//    public int Age;

//    public Person()
//    {
//        Name = "Petya";
//        Age = 40;
//    }

//    // Конструктор с параметрами
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }
//}

Person person = new Person();
Person person1 = new Person("Vasya", 25);
Person person2 = new Person("Nina", 28);
Person person3 = new Person("Ivan", 45);

Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
Console.WriteLine($"Имя: {person1.Name}, Возраст: {person1.Age}");
Console.WriteLine($"Имя: {person2.Name}, Возраст: {person2.Age}");
Console.WriteLine($"Имя: {person3.Name}, Возраст: {person3.Age}");

// Выводим количество созданных объектов
Console.WriteLine($"Всего создано объектов Person: {Person.ObjectCount}");

Car car1 = new Car("BMW", "m7", 2025);
Car car2 = new Car("Audi", "a7", 2024);
Car car3 = new Car("Volkswagen", "Tuareg", 2023);
Car car4 = new Car("Mercedes - Benz", "gle 350", 2020);

// Выводим информацию о каждой машине
car1.ShowInfo();
car2.ShowInfo();
car3.ShowInfo();
car4.ShowInfo();

car1.Start();
car2.Start();
car3.Start();
car4.Start();

car1.Drive();
car2.Drive();
car3.Drive();
car4.Drive();

car1.Stop();
car2.Stop();
car3.Stop();
car4.Stop();

Console.ReadLine();

class Person
{
    public string Name;
    public int Age;

    // Статическое поле-счётчик
    public static int ObjectCount = 0;

    public Person()
    {
        Name = "Petya";
        Age = 40;
        ObjectCount++; // Увеличиваем счётчик при создании объекта
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        ObjectCount++; // Увеличиваем счётчик при создании объекта
    }
}

class Car
{
    public string Brand;
    public string Model;
    public int YearOfManufacture;

    // Конструктор с параметрами
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        YearOfManufacture = year;
    }

    // Метод для вывода информации о машине
    public void ShowInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Год выпуска: {YearOfManufacture}");
    }

    public void Start()
    {
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Engine started ready to move ");
    }

    public void Drive()
    {
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Engine started, move, wroom-wroom, beep");
    }
    
    public void Stop()
    {
        Console.WriteLine($"Марка: {Brand}, Модель: {Model}, Stopped, engine stopped");
    }
}