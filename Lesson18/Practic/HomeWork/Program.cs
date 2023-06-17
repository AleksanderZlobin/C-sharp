// Task # 64.
// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// string printNumbers(int a)
// {
//     if (a == 1)
//         return $"{a}";
//     return $"{a}, " + printNumbers(a - 1);
// }


// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(n));



// Task # 66.
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.


// int sumNumbers(int a, int b)
// {
//     if (a == b)
//         return a;
//     return sumNumbers(a, b - 1) + b;
// }

// Console.Clear();
// Console.Write("Введите значение M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(sumNumbers(m, n));



// Task # 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


// int functionAkkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return functionAkkerman(m - 1, 1);
//     else return functionAkkerman(m - 1, functionAkkerman(m, n - 1));
// }

// Console.Clear();
// Console.Write("Введите неотрицательное число M: ");
// int m = int.Parse(Console.ReadLine()!);
// while (m < 0)
// {
//     Console.WriteLine($"Вы ошиблись!\n Введите неотрицательное число M: ");
//     m = int.Parse(Console.ReadLine()!);
// }
// Console.Write("Введите значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// while (m < 0)
// {
//     Console.WriteLine($"Вы ошиблись!\n Введите неотрицательное число N: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine(functionAkkerman(m, n));