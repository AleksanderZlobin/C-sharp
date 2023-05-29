// Task # 10
// Напишите программу, которая принимает на вход трехзначное число и
// на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 100 || n > 999)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine(n / 10 % 10);


// Task # 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// if (n < 100)
//     Console.Write("третьей цифры нет");
// else 
// {
//     while (n > 999)
//         n = n / 10;
// Console.WriteLine($"Третья цифра слева {n % 10}");
// }


// Task # 15
// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 7)
// {
//     Console.Write("Вы ошиблись!\nВведите число от 1 до 7: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if (n > 5)
//     Console.WriteLine("Этот день выходной!");
// else
//     Console.WriteLine("Этот день не выходной");


// Доп. задача
// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!), max1 = n, max2 = 0;
while (n != 0)
{
    Console.Write("Введите число: ");
    n = int.Parse(Console.ReadLine()!);
    if (max1 < n)
    {
        max2 = max1;
        max1 = n;
    }
    else if (max2 < n)
        max2 = n;
}
Console.WriteLine($"Второй максимум: {max2}");
