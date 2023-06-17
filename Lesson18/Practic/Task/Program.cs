// Task # 63 и 65
// 63. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// 65. Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.


// string printNumbers(int a, int b)
// {
//     if (a == b)
//         return $"{b}";
//     return printNumbers(a, b - 1) + $", {b}";
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(printNumbers(m, n));
// p(4, 9) -> p(4, 8) + ", 9" = "4, 5, 6, 7, 8" + ", 9" = "4, 5, 6, 7, 8, 9"
//            |
//            p(4, 7) + ", 8" = "4, 5, 6, 7" + ", 8" = "4, 5, 6, 7, 8"
//            |
//            p(4, 6) + ", 7" = "4, 5, 6" + ", 7" = "4, 5, 6, 7"
//            |
//            p(4, 5) + ", 6" = "4, 5" + ", 6" = "4, 5, 6"
//            |
//            p(4, 4) + ", 5" = "4" + ", 5" = "4, 5"
//            |
//            "4"



// Task # 67
// Напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.


// int summaCifr(int a)
// {
//     if (a < 10)
//         return a;
//     return summaCifr(a / 10) + a % 10;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(summaCifr(n));
// s(12345) -> s(1234) + 5 = 10 + 5 = 15
//             |
//             s(123) + 4 = 6 + 4 = 10
//             |
//             s(12) + 3 = 3 + 3 = 6
//             |
//             s(1) + 2 = 1 + 2 = 3
//             |
//             1



// Task # 69
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит A в целую степень B с помощью рекурсии.


// int power(int a, int b)
// {
//     if (b == 0)
//         return 1;
//     return power(a, b - 1) * a;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine(power(n, m));
// p(5, 3) -> p(5, 2) * 5 = 25 * 5 = 125
//            |
//            p(5, 1) * 5 = 5 * 5 = 25
//            |
//            p(5, 0) * 5 = 1 * 5 = 5
//            |
//            1

