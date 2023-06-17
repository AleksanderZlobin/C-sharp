// Рекурсия.
// Необходимо посчитать сумму чисел a и b. Из операций можно использовать только +-1.
// int summa(int a, int b)
// {
//     if (a == 0)
//         return b;
//     return summa(a - 1, b + 1);
// }

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine(summa(n, m));
// s(5, 4) -> s(4, 5) -> s(3, 6) -> s(2, 7) -> s(1, 8) -> s(0, 9) -> 9