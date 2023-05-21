// Demo task # 1
// Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное на само себя)

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(n * n);

// Task # 1
// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// // == - проверка на равенство
// // = - присвоение значения
// // != - проверка на неравенство
// // >= or <=
// // => or =< - ERROR
// if (b * b == a)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");

// Task # 3
// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

// Console.Clear();
// Console.Write("Введите номер дня недели: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблись!\nВведите номер дня недели: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if (n == 1)
//     Console.WriteLine("Понедельник");
// else if (n == 2)
//     Console.WriteLine("Вторник");
// else if (n == 3)
//     Console.WriteLine("Среда");
// else if (n == 4)
//     Console.WriteLine("Четверг");
// else if (n == 5)
//     Console.WriteLine("Пятница");
// else if (n == 6)
//     Console.WriteLine("Суббота");
// else
//     Console.WriteLine("Воскресенье");

// Task # 5
// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = (-1) * n; i <= n; i++)
//     Console.Write($"{i} ");

// Task # 7
// Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine(n % 10);



