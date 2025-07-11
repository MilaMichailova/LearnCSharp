//See https://aka.ms/new-console-template for more information
//Console.WriteLine("Метод для вычисления суммы массива чисел.");

//BigInteger SumArrayForeach(BigInteger[] array) //объявляем метод возвращающий число инт принмающий массив инт(чисел)
//{
//    BigInteger sum = 0; //объявляем переменную сум типа инт-число и присваиваем 0
//    foreach (BigInteger num in array) //в цикле перебираем кажый элемент(число)
//        sum += num; //впеременную дум добавляем каждое число полученое в процессе работы цикла в процессе каждой итарации
//    Console.WriteLine($"Результат работы метода суммы: {sum} "); //выводим сумму в консоль
//    return sum; //останавливаем цикл
//}

//SumArrayForeach([1, 5, 2, 7, 4]);//вызываем метод передавая необходимый массив как параметр


//Console.WriteLine("Метод , который меняет значение переменной через ref.");

//static void ModifyValue(ref BigInteger value)
//{
//    value *= 2; // Удваиваем значение исходной переменной
//}


//    BigInteger number = 5;
//    Console.WriteLine($"До вызова метода: {number}"); // 5

//    // Вызываем метод с ref
//    ModifyValue(ref number);

//    Console.WriteLine($"После вызова метода: {number}"); // 10



//using System.Numerics;

//static BigInteger Factorial(BigInteger n)
//{
//    if (n <= 1)
//        return 1;
//    return n * Factorial(n - 1);
//}


//Console.WriteLine("Рекурсивный метод вычисления факториала.");

//while (true) // Бесконечный цикл для повторных вычислений
//{
//    Console.Write("Введите число для вычисления факториала: ");

//    // Обработка некорректного ввода числа
//    if (!BigInteger.TryParse(Console.ReadLine(), out BigInteger number))
//    {
//        Console.WriteLine("Ошибка: введите целое число!");
//        continue;
//    }

//    if (number < 0)
//        Console.WriteLine("Факториал отрицательного числа не определен");
//    else
//        Console.WriteLine($"{number}! = {Factorial(number)}");

//    // Предложение продолжить
//    Console.WriteLine("Введите (да/нет/y) для продолжения, или любой другой символ для выхода");
//    string answer = Console.ReadLine().Trim().ToLower();

//    if (answer != "да" && answer != "yes" && answer != "y")
//    {
//        Console.WriteLine("Выход из программы.");
//        break;
//    }
//}



//using System.Numerics;

//Console.WriteLine("Проверка простоты числа");

//while (true)
//{
//    Console.Write("Введите число: ");
//    string input = Console.ReadLine();

//    if (!int.TryParse(input, out int number))
//    {
//        Console.WriteLine("Ошибка ввода! Введите целое число.");
//        continue;
//    }

//    // Выбираем метод проверки (можно заменить на другой)
//    bool isPrime = IsPrimeBig(number);

//    Console.WriteLine($"Число {number} {(isPrime ? "простое" : "составное")}");

//    Console.Write("Проверить еще? (да/нет): ");
//    if (Console.ReadLine().ToLower() != "да")
//        break;
//};


//// Простейший метод проверки простоты (для маленьких чисел)
//static bool IsPrimeBasic(int number)
//{
//    // Обработка особых случаев
//    if (number <= 1) return false;
//    if (number == 2) return true;
//    if (number % 2 == 0) return false;

//    // Проверяем делители до корня из числа
//    for (int i = 3; i * i <= number; i += 2)
//    {
//        if (number % i == 0)
//            return false;
//    }
//    return true;
//};

//// Более эффективный метод с кэшированием простых делителей
//static bool IsPrimeOptimized(int number)
//{
//    if (number <= 1) return false;
//    if (number <= 3) return true;
//    if (number % 2 == 0 || number % 3 == 0) return false;

//    // Проверяем делители вида 6k ± 1
//    for (int i = 5; i * i <= number; i += 6)
//    {
//        if (number % i == 0 || number % (i + 2) == 0)
//            return false;
//    }
//    return true;
//};



//// Метод для очень больших чисел (но медленный)
//static bool IsPrimeBig(BigInteger number)
//{
//    if (number <= 1) return false;
//    if (number == 2) return true;
//    if (number % 2 == 0) return false;

//    for (BigInteger i = 3; i * i <= number; i += 2)
//    {
//        if (number % i == 0)
//            return false;
//    }
//    return true;
//};

Console.WriteLine("Перегрузка методов с разным набором параметров");
    Logger log = new Logger();
    log.Log("Vasya");                 // [LOG] Vasya
    log.Log("Vasya", 6621);           // [ERROR 6621] Vasya
    log.Log("Vasya", 6620, true);     // [CRITICAL 6620] Vasya

    Console.WriteLine("\nНажмите любую клавишу для выхода...");
    Console.ReadKey(); // Ждет нажатия ЛЮБОЙ клавиши}

class Logger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }

    public void Log(string message, int errorCode)
    {
        Console.WriteLine($"[ERROR {errorCode}] {message}");
    }

    public void Log(string message, int errorCode, bool isCritical)
    {
        string level = isCritical ? "CRITICAL" : "WARNING";
        Console.WriteLine($"[{level} {errorCode}] {message}");
    }
}
