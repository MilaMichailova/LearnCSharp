// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Lesson 5 Task");

Animal animal = new Animal("Hello! I'm an animal!");
animal.Speak();

Dog rex = new Dog("Rex", "Hello! I'm a dog!");
rex.Speak();

Cat tom = new Cat("Tom", "Hello! I'm a cat!");
tom.Speak();

Bird bird = new Bird();
bird.Fly();

Duck duck = new Duck();
duck.Fly();
duck.Swim();

Fish fish = new Fish();
fish.Swim();

Vehicle myCar = new Car(new GasolineEngine());
myCar.Start();
myCar.Drive();
myCar.Stop();

Console.WriteLine();

Vehicle myElectricBike = new Motorcycle(new ElectricEngine());
myElectricBike.Start();
myElectricBike.Drive();
myElectricBike.Stop();

Console.WriteLine();

Vehicle myTruck = new Truck(new DieselEngine());
myTruck.Start();
myTruck.Drive();
myTruck.Stop();

Console.ReadLine();

class Animal
{
    private string _message;

    public string Message
    {
        get { return _message; }
        set { _message = value; }
    }

    public Animal(string message)
    {
        _message = message;
    }

    public virtual void Speak()
    {
        Console.WriteLine(Message);
    }
}

class Dog : Animal
{
    public string Name { get; set; }

    public Dog(string name, string message) : base(message)
    {
        Name = name;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Message} My name is {Name}.");
    }
}

class Cat : Animal
{
    public string Name { get; set; }

    public Cat(string name, string message) : base(message)
    {
        Name = name;
    }

    public override void Speak()
    {
        Console.WriteLine($"{Message} My name is {Name}.");
    }
}

// Интерфейс возможность летать
interface IFlyable
{
    void Fly();
}

// Класс птица реализующая интерфейс IFlyable
class Bird : IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }
}


// Интерфейс двигателя
interface IEngine
{
    void Start();
    void Stop();
    string GetEngineType();
}

// Конкретные реализации двигателей
class GasolineEngine : IEngine
{
    public void Start() => Console.WriteLine("Gasoline engine started.");
    public void Stop() => Console.WriteLine("Gasoline engine stopped.");
    public string GetEngineType() => "Gasoline Engine";
}

class ElectricEngine : IEngine
{
    public void Start() => Console.WriteLine("Electric engine started silently.");
    public void Stop() => Console.WriteLine("Electric engine stopped.");
    public string GetEngineType() => "Electric Engine";
}

class DieselEngine : IEngine
{
    public void Start() => Console.WriteLine("Diesel engine started with a roar.");
    public void Stop() => Console.WriteLine("Diesel engine stopped.");
    public string GetEngineType() => "Diesel Engine";
}

// Базовый класс транспортного средства
abstract class Vehicle
{
    protected IEngine Engine;

    public Vehicle(IEngine engine)
    {
        Engine = engine;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting vehicle with {Engine.GetEngineType()}");
        Engine.Start();
    }

    public virtual void Stop()
    {
        Console.WriteLine("Stopping vehicle...");
        Engine.Stop();
    }

    public abstract void Drive();
}

// Конкретные транспортные средства
class Car : Vehicle
{
    public Car(IEngine engine) : base(engine) { }

    public override void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Truck : Vehicle
{
    public Truck(IEngine engine) : base(engine) { }

    public override void Drive()
    {
        Console.WriteLine("Truck is hauling cargo.");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(IEngine engine) : base(engine) { }

    public override void Drive()
    {
        Console.WriteLine("Motorcycle is speeding on the road.");
    }
}

// Интерфейс возможность плавать
interface ISwimmable
{
    void Swim();
}

// Класс Утка  реализующая интерфейс IFlyable и ISwimmable
class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("The Duck is flying.");
    }
    public void Swim()
    {
        Console.WriteLine("The Duck is swiming.");
    }
}

class Fish : ISwimmable
{
    public void Swim()
    {
        Console.WriteLine("The Fish is swiming.");
    }
}