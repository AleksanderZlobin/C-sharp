// Методы(ООП)
// void - процедура
// TypeData - функции

// void f(ref int n)
// {
//     n += 5; // n = n + 5;
// }


// Console.Clear();
// int m = 10;
// f(ref m);
// Console.WriteLine(m);


// void f(int[] n)
// {
//     n[0] = n[0] + 5;
// }


// Console.Clear();
// int[] m = {5, 3, 90, 16, 82};
// f(m);
// Console.WriteLine($"[{string.Join(", ", m)}]");


// void f(int n, int m=15)
// {
//     Console.WriteLine($"{n} + {m} = {n + m}");
// }


// Console.Clear();
// f(10, 4);

// Пользователь вводит 2 числа. Необходимо вывести максимальное из них

// string MaxNumbers(int n, int m)
// {
//     if (n > m) // -> n <= m
//         return $"{n}";
//     else if (n < m)
//         return $"{m}";
//     return "=";
// }


// Console.Clear();
// string result = MaxNumbers(10, 10);
// Console.WriteLine(result);


// Генерация дробных чисел

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