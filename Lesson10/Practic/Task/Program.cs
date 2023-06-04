// Task # 31
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10); // [-9; 9]
// }


// void SearchSum(int[] array)
// {
//     int sumPositivе = 0, allSum = 0;
//     foreach (int element in array)
//     {
//         if (element > 0)
//             sumPositivе += element;
//         allSum += element;
//     }
//     Console.WriteLine($"Сумма положительных чисел равна: {sumPositivе}");
//     Console.WriteLine($"Сумма отрицательных чисел равна: {allSum - sumPositivе}");
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// SearchSum(array);
// foreach (int element in array)
// {
//     Console.WriteLine(element);
// }


// Task # 32
// Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-50, 51); // [-50; 50]
// }


// void ReverseNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] *= (-1);
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// ReverseNumbers(array);
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");


// Task # 
// Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-50, 51); // [-50; 50]
// }


// string SearchNumber(int[] array, int number)
// {
//     foreach (int element in array)
//     {
//         if (element == number)
//             return "yes";
//     }
//     return "no";
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.Write("Введите число, которое хотите найти: ");
// int k = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SearchNumber(array, k));


// Task # 35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество 
// элементов массива, значения которых лежат в отрезке [10,99]. 

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101); // [-100; 100]
// }


// int CountNumbers(int[] array)
// {
//     int count = 0;
//     foreach (int element in array)
//     {
//         if (element >= 10 && element <= 99)
//             count++;
//     }
//     return count;
// }


// Console.Clear();
// // Console.Write("Введите кол-во элементов массива: ");
// // int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[123];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine(CountNumbers(array));


// Task # 37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 11); // [0, 10]
// }


// int[] proizvedenie(int[] array, int[] result)
// {
//     for (int i = 0; i < result.Length; i++)
//         result[i] = array[i] * array[array.Length - 1 - i];

//     return result;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// int[] result = new int[n / 2 + n % 2];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Конечный массив: [{string.Join(", ", proizvedenie(array, result))}]");

