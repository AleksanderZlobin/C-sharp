// Task # 2
// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите первое число: ");
// int b = int.Parse(Console.ReadLine()!);
// if (a > b)
//     Console.WriteLine($"{a} больше, чем {b}");
// else
//     Console.WriteLine($"{b} больше, чем {a}");


// Task # 4
// Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);
// int max = a;
// if (b > max)
//     max = b;
// if (c > max)
//     max = c;
// Console.WriteLine($"{max} максимальное число");


// Task # 6
// Напишите программу, которая на вход принимает число и выдает, является ли число 
// четным(делится ли оно на два без остатка)

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// if (a % 2 == 0)
//     Console.WriteLine($"{a} - это четное число");
// else 
//     Console.WriteLine($"{a} - это нечетное число");


// Task # 8
// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все четные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
for (int i = 2; i <= N; i+=2)
    Console.Write($"{i} ");
