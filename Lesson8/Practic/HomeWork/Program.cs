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


// Additional Task # 1
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=702
// Дана последовательность из N целых чисел и число K. Необходимо 
// сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
// если K – положительное и влево, если отрицательное.


// Additional Task # 2
// https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=6&id_topic=117&id_problem=723
// Известно, что любое чётное число, большее 2, представимо в виде суммы 2 простых чисел, 
// причём таких разложений может быть несколько. Впервые гипотезу о существовании данного разложения 
// сформулировал математик Х. Гольдбах.
// Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного 
// чётного числа. Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти 
// пару, содержащую наименьшее простое число.