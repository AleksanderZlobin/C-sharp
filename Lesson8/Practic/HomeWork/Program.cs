// Task # 25
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// Console.Clear();
// Console.WriteLine("Введите число А: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B: ");
// int B = int.Parse(Console.ReadLine()!);
// while (B <= 0)
// {
//     Console.WriteLine("Ошибка!\nВведите натуральное число: ");
//     B = int.Parse(Console.ReadLine()!);
// }
// int degree = A;
// for (int i = 1; i < B; i++)
//     degree = degree * A;
// Console.WriteLine($"{A} в степени {B} равно {degree}");


// Task # 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Оформить в математическом виде.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// int sum = 0;
// while (n > 0)
// {
//     sum += n % 10;
//     n = n / 10;
// }
// Console.WriteLine(sum);


// Task # 29
// Напишите программу, которая задает массив из
// 8 элементов и выводит их на экран.

// Console.Clear();
// int[] array = new int[8];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine($"Введите {i + 1} элемент массива: ");
//     int n = int.Parse(Console.ReadLine()!);
//     array[i] = n;
// }
// Console.WriteLine($"Результат: [{string.Join(",", array)}]");


// Additional Task # 1 Суперсдвиг
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702
// Дана последовательность из N целых чисел и число K. Необходимо 
// сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
// если K – положительное и влево, если отрицательное.


// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] a = new int[n];
// int[] b = new int[n];

// for (int i = 0; i < n; i++)
//     a[i] = new Random().Next(1, 21); // [1; 20]

// Console.WriteLine($"Начальный массив: [{string.Join(", ", a)}]");
// Console.Write("Введите кол-во сдвига: ");
// int k = int.Parse(Console.ReadLine()!);
// k = k % n;
// if (k > 0)
// {
//     for (int i = 0; i < k; i++)
//         b[i] = a[n - k + i];
//     for (int i = 0; i < n - k; i++)
//         b[k + i] = a[i];
//     Console.WriteLine($"Конечный массив: [{string.Join(", ", b)}]");
// }
// else
// {
//     k = -k;
//     for (int i = 0; i < k; i++)
//         b[n - k + i] = a[i];
//     for (int i = 0; i < n - k; i++)
//         b[i] = a[k + i];
//     Console.WriteLine($"Конечный массив: [{string.Join(", ", b)}]");
// }


// Additional Task # 2 Гипотеза Гольдбаха.
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=117&id_problem=723
// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, 
// причём таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения 
// сформулировал математик Х. Гольдбах.
// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного 
// чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти 
// пару, содержащую наименьшее простое число.


// int n = Convert.ToInt32(Console.ReadLine());
// int countDel = 0, i, j, k, m;
// for (i = 2; i <= n / 2; i++)
// {
//     countDel = 0;
//     for (j = 2; j <= i / 2; j++)
//     {
//         if (i % j == 0)
//             countDel++;
//     }
//     if (countDel == 0)
//     {
//         m = n - i;
//         for (k = 2; k <= m / 2; k++)
//         {
//             if (m % k == 0)
//                 countDel++;
//         }
//         if (countDel == 0)
//         {
//             Console.WriteLine($"{i} {m}");
//             return;
//         }
//     }
// }