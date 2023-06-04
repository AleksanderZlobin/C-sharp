// Task # 39
//


// void InputArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);
// }


// void ReverseArray(double[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         double temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = int.Parse(Console.ReadLine()!);
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
// ReverseArray(array);
// Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");



// Task # 40
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


// Console.Clear();
// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// int c = int.Parse(Console.ReadLine()!);
// if (a < b + c && b < c + a && c < a + b)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");



// Task # 42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// string result = string.Empty;
// while (n > 0)
// {
//     result = $"{n % 2}" + result;
//     n /= 2;
// }
// Console.WriteLine(result);



// Task # 44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


//// int fib(int n)
//// {
////     if (n == 0 || n == 1)
////         return n;
////     return fib(n - 1) + fib(n - 2);
//// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), a0 = 0, a1 = 1, x;
//// Console.WriteLine(fib(n));
// for (int i = 0; i < n; i++)
// {
//     Console.Write($"{a0} ");
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }


// Task # 45
// Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.


// Console.Clear();
// int[] a = {1, 2, 3, 4, 5};
// int[] b = new int[a.Length];

// for (int i = 0; i < b.Length; i++)
//     b[i] = a[i];

// b[0] = b[0] + 5;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));


