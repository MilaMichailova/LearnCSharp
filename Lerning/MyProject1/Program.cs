// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Начиаю учить c#!");

bool isLie = false; // bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean

byte bit1 = 1; // byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte

sbyte bit2 = 102; // sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte

short n1 = 1; // short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16

ushort n2 = 102; // ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16

int num = 0b101; // int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
                 // Представлен системным типом System.Int32. Все целочисленные литералы по умолчанию представляют значения типа int:

uint a = 10; // uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32

long l = -0b101; // long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64

ulong r = 11111111; // ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. Представлен системным типом System.UInt64

float f = 3.1f; //float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта. Представлен системным типом System.Single необходим суффикс f

double d = 2.5; // хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. Представлен системным типом System.Double

decimal c = 2.333m; // необходим суффикс m//
                    // decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой,
                    // имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. Представлен системным типом System.Decimal

char cc = 'a'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char.

string name = "mila"; // string: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы.

object obj = "hello"; // может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
                      // Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET.

Console.WriteLine($"bool isLie = {isLie}"); //Используется интерполяция строк $"текст {переменная}" для удобного вывода
Console.WriteLine($"byte bit1 = {bit1}");
Console.WriteLine($"sbyte bit2 = {bit2}");
Console.WriteLine($"short n1 = {n1}");
Console.WriteLine($"ushort n2 = {n2}");
Console.WriteLine($"int num = {num}");
Console.WriteLine($"uint a = {a}");
Console.WriteLine($"long l = {l}");
Console.WriteLine($"ulong r = {r}");
Console.WriteLine($"float f = {f}");
Console.WriteLine($"double d = {d}");
Console.WriteLine($"decimal c = {c}");
Console.WriteLine($"char cc = {cc}");
Console.WriteLine($"string name = {name}");
Console.WriteLine($"object obj = {obj}");

// Использовать var и dynamic, объяснить разницу

var number = 1;
// var — это неявно типизированная переменная,
// компилятор определяет тип во время компиляции на основе присвоенного значения.
// После объявления тип переменной фиксируется и не может изменяться.


dynamic string1 = "44";
// dynamic — это тип, который отключает проверку типов во время компиляции и переносит её на время выполнения.
// Переменная dynamic может менять тип и вызывать методы, которые будут проверены во время выполнения.
// Если метода нет — будет ошибка во время запуска.


// number = "11"; // Ошибка компиляции! Нельзя присвоить строку переменной типа int
// string1 = 44;
// string1.NonExistentMethod();
// Ошибка во время выполнения, так как у int нет такого метода


// Попробовать nullable типы (int? x = null;)

int? x = null;

if (x.HasValue)
{
    Console.WriteLine("Значение x: " + x.Value);
}
else
{
    Console.WriteLine("Значение отсутствует");
}

x = 10;

if (x.HasValue)
{
    Console.WriteLine("Значение x: " + x.Value);
}
else
{
    Console.WriteLine("Значение отсутствует");
}


// Написать программу, которая запрашивает имя пользователя и выводит приветствие


Console.WriteLine("Как к Вам обращаться?");

string UserName  = Console.ReadLine();

if (UserName.Length > 1)
{

    Console.WriteLine($"Здраствуйте, {UserName}!");
}
else
{
    Console.WriteLine("Вы не представились");
    Console.WriteLine("Введите Ваше имя и нажмите Enter");
    UserName = Console.ReadLine();

    if (UserName.Length > 1)
    {
        Console.WriteLine($"Здравствуйте, {UserName}!");
    }
    else
    {
        Console.WriteLine("Очень жаль, до свидания.");
    }
}