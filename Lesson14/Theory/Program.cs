// Генерация случайных дробных чисел.


// void InputArray(double[] array)
// {
//     int end = 30, begin = 10;
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");


// Ввод нескольких чисел в одну строку.


// int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// Console.WriteLine(size[0] + size[1]);