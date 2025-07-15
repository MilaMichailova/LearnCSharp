// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lesson, 6 Task");

Student alice = new Student(1, "Alice");
Student bob = new Student(2, "Bob");

Course math = new Course("MATH101", "Mathematics");
Course physics = new Course("PHYS101", "Physics");

// Записываем студентов на курсы
alice.EnrollInCourse(math);
alice.EnrollInCourse(physics);

bob.EnrollInCourse(physics);

// Выводим информацию
alice.ShowCourses();
Console.WriteLine();
bob.ShowCourses();
Console.WriteLine();

math.ShowStudents();
Console.WriteLine();
physics.ShowStudents();

// Вводим информацию о доме и комнатах
House myHouse = new House("123 Main Street");

myHouse.AddRoom("Living Room", 25.5);
myHouse.AddRoom("Kitchen", 12.3);
myHouse.AddRoom("Bedroom", 18.0);

// Выводим информацию
myHouse.ShowRooms();



var author = new Author("Leo Tolstoy");
var address = new Address("Lenina St.", "Moscow");
var library = new Library("Central Library", address);

library.AddBook("War and Peace", author);
library.AddBook("Anna Karenina", author);

Console.WriteLine($"Library: {library.Name}, located at {library.Address.Street}, {library.Address.City}");
foreach (var book in library.Books)
{
    Console.WriteLine($"Book: {book.Title}, Author: {book.Author.Name}");
}

Console.ReadLine();


// Класс Student
class Student
{
    public string Name { get; set; }
    public int Id { get; set; }

    // Курсы, на которые записан студент
    private List<Course> courses = new List<Course>();

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    // Добавить курс студенту
    public void EnrollInCourse(Course course)
    {
        if (!courses.Contains(course))
        {
            courses.Add(course);
            course.AddStudent(this); // поддерживаем связь с обеих сторон
        }
    }

    public void ShowCourses()
    {
        Console.WriteLine($"Student {Name} is enrolled in courses:");
        foreach (var course in courses)
        {
            Console.WriteLine($"- {course.Title}");
        }
    }
}

// Класс Course
class Course
{
    public string Title { get; set; }
    public string Code { get; set; }

    // Студенты, записанные на курс
    private List<Student> students = new List<Student>();

    public Course(string code, string title)
    {
        Code = code;
        Title = title;
    }

    // Добавить студента на курс
    public void AddStudent(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
            // Чтобы избежать бесконечной рекурсии, не вызываем student.EnrollInCourse здесь
        }
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Course {Title} has students:");
        foreach (var student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}


// Класс Room — часть House
class Room
{
    public string Name { get; private set; }
    public double Area { get; private set; } // площадь в кв.м

    public Room(string name, double area)
    {
        Name = name;
        Area = area;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Room: {Name}, Area: {Area} m*2 ");
    }
}

// Класс House — содержит комнаты (композиция)
class House
{
    public string Address { get; private set; }

    // Список комнат — создаётся и управляется домом
    private List<Room> rooms = new List<Room>();

    public House(string address)
    {
        Address = address;
    }

    // Добавление комнаты в дом
    public void AddRoom(string name, double area)
    {
        Room room = new Room(name, area);
        rooms.Add(room);
    }

    // Вывод информации о доме и комнатах
    public void ShowRooms()
    {
        Console.WriteLine($"House at {Address} has rooms:");
        foreach (var room in rooms)
        {
            room.ShowInfo();
        }
    }
}


// Ассоциация: Book знает Author, но не владеет им
public class Author
{
    public string Name { get; set; }
    public Author(string name) => Name = name;
}

public class Book
{
    public string Title { get; set; }

    // Ассоциация: ссылка на автора (не владеет им)
    public Author Author { get; set; }

    public Book(string title, Author author)
    {
        Title = title;
        Author = author;
    }
}

// Агрегация: Address существует отдельно, Library хранит ссылку на него
public class Address
{
    public string Street { get; set; }
    public string City { get; set; }

    public Address(string street, string city)
    {
        Street = street;
        City = city;
    }
}

// Композиция: Library владеет книгами, создаёт и уничтожает их
public class Library
{
    public string Name { get; set; }

    // Агрегация: адрес передаётся извне
    public Address Address { get; set; }

    // Композиция: библиотека владеет книгами
    private List<Book> books = new List<Book>();

    public Library(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    // Метод добавления книги — библиотека создаёт книги сама
    public void AddBook(string title, Author author)
    {
        books.Add(new Book(title, author));
    }

    public IEnumerable<Book> Books => books.AsReadOnly();
}
//Ассоциация: Book содержит ссылку на Author. Автор создаётся отдельно, книга просто хранит ссылку.
//Агрегация: Library имеет ссылку на Address, который создаётся вне библиотеки. Адрес может существовать отдельно.
//Композиция: Library создаёт и хранит объекты Book в своём списке — книги не существуют без библиотеки.
