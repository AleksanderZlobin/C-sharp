// Demo task # 2
// Напишите программу, которая выводит случайное число из
// отрезка [10, 99) и показывает наибольшую цифру числа.

// Console.Clear();
// int number = new Random().Next(10, 100); // [10;99)
// Console.WriteLine(number);
// int n1 = number / 10;
// int n2 = number % 10;
// // 1 == 2, 1 > 2, 1 < 2
// if (n1 > n2)
//     Console.WriteLine(n1);
// else   
//     Console.WriteLine(n2);


// Task # 11
// Напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру этого числа.

// Console.Clear();
// int number = new Random().Next(100, 1000); // [100, 999)
// Console.WriteLine(number);
// Console.WriteLine(number / 100 * 10 + number % 10);


// Task # 12
// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если число 2
// не кратно числу 1, то программа выводит остаток от деления.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a % b == 0)
//     Console.Write("кратно");
// else
//     Console.Write($"не кратно, остаток {a % b}");


// Task # 14
// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// if (a % 161 == 0) // a % 7 == 0 && a % 23 == 0  Умножение условия работает только с простыми числами
//     Console.WriteLine("кратно");
// else
//     Console.WriteLine("не кратно");


// Task # 16
// Напишите программу, которая принимает на вход два числа и
// проверяет, является ли одно число квадратом другого.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a * a == b || b * b == a)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");


