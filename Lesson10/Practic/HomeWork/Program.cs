// Task # 34
// Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000); // [100, 999]
// }


// int EvenNumbers(int[] array, int result)
// {
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0) result++;
//     return result;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// int result = 0;
// InputArray(array);
// Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Количество четных чисел: {EvenNumbers(array, result)}");




// Task # 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.


// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 1000);
// }


// int SumNumbersOddIndex(int[] array, int sum)
// {
//     for (int i = 0; i < array.Length; i++)
//         if (i % 2 == 1) sum += array[i];
//     return sum;
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// int sum = 0;
// InputArray(array);
// Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumNumbersOddIndex(array, sum)}");



// Task # 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// void InputArray(double[] array)
// {
//     int end = 100, begin = 1;
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
// }

// double Max(double[] array)
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] > max) max = array[i];
//     return max;
// }

// double Min(double[] array)
// {
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] < min) min = array[i];
//     return min;
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] arr = new double[n];
// InputArray(arr);
// Console.WriteLine($"Заданный массив: [{string.Join("; ", arr)}]");
// Console.WriteLine($"Минимальное значение: {Min(arr)}, максимальное значение: {Max(arr)}");
// Console.WriteLine($"Разница между минимальным и максимальным равна: {Math.Round(Max(arr) - Min(arr), 2)}");



// Task # 1 Additional Статистика.
// Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, 
// чтобы оставаться ударником. В текущей четверти Вася заметил следующую закономерность: 
// по нечетным дням месяца он получал тройки, а по четным – четверки. Так же он помнит, 
// в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни для того, 
// чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив 
// четные и нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.


// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         int n = int.Parse(Console.ReadLine()!), count = 0;
//         int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
//         foreach (int x in size)
//         {
//             if (x % 2 == 1)
//             {
//                 Console.Write($"{x} ");
//                 count++;
//             }
//         }
//         Console.WriteLine();
//         foreach (int x in size)
//         {
//             if (x % 2 == 0)
//                 Console.Write($"{x} ");
//         }
//         Console.WriteLine();
//         if (count <= n - count)
//             Console.WriteLine("YES");
//         else
//             Console.WriteLine("NO");
//     }
// }