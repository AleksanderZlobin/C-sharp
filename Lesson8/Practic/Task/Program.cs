// Task # 24
// Напишите программу, которая принимает на вход
// число (a) и выдает сумму чисел от 1 до а.

// Console.Clear();
// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма от 1 до {a}: {((a + 1) / 2.0) * a}"); // Математическое выражение 
//                                                                 // арифметической прогрессии.

// Task # 26
// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int count = 0, m = n;
// while (n > 0)
// {
//     n /= 10;
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе {m} равно: {count}");


// Task 28
// Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = 1;
// for (int i = 1; i <= n; i++)
//     result *= i;
// Console.WriteLine($"{n}! = {result}");


// Task # 30
// Напишите программу, которая выводит массив
// из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 2);
// Console.WriteLine($"Результат: [{string.Join(",", array)}]");



