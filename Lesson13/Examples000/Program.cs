// Task # 1.
// Собрать строку с числами от a до b, a <= b.


// Итеративный подход (ветвления и циклы).
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
// Рекурсия.
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
COnsole.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


// -------------------------------------------
// Task # 2.
// Собрать строку с числами от a до b, a >= b.


// Итеративный подход (ветвления и циклы).
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}
// Рекурсия.
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a}";
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
COnsole.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


// -----------------------------------
// Task # 3.
// Сумма чисел от 1 до n.


// Итеративный.
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
// Рекурсия.
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55


// ----------------------------------
// Task # 4.
// Факториал числа.


// Итеративный.
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
// Рекурсия.
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800


// --------------------------------------
// Task # 5.
// Вычислить a в степени n.


// Итеративный.
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
// Рекурсия
int PowerRec(int a, int n)
{
    // return n == 0 ? : PowerRec(a, n - 1) * a; // Тернарный оператор.
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
// Рекурсия с математическим методом возведения в степень.
// {1} a в степени m * a в степени n = a в степени (m + n).
// {2} a в степени m в степени n = a в степени (m * n).
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024
Console.WriteLine(PowerRecMath(2, 10)); // 1024


// ----------------------------------------
// Task # 6
// Перебор слов.
// В некотором машинном алфавите имеются четыре буквы
// "а", "и", "с", "в". Покажите все слова, состоящие
// из T букв, которые можно построить из букв этого алфавита.


// Итеративный.
char[] s = { "а", "и", "с", "в" };
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++,-5}{s[i]}");
    // Перебор однобуквенных слов. Чем больше T, тем больше циклов.
}
// Рекурсия, когда не знаем T.
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[5]);


// ---------------------------------
// Task # 7
// Алгоритм обхода директории папки.


// Рекурсия.
void CatalogInfo(string path, string indent = "") // indent - отступы для вложенности
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = @"/Users/myne/Desktop/Практические занятия/C-sharp";
CatalogInfo(path);


// ------------------------------------------
// Task # 8
// Игра в пирамидки.


// Рекурсия
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
// with - 1-ый шпиль, on - 3-ий шпиль, some - 2-ой шпиль, count - кол-во блинов.
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();


// ------------------------------------------
// Task # 9
// Обход разных структур.
// ((4 - 2) * (1 + 3))) / 10
// Бинарное дерево.
//                      /(1)
//          *(2)          10(3)
//     -(4)      +(5) empty(6)  empty(7)            a(i)
//   4(8)2(9)  1(10)3(11)                       a(2i)  a(2i+1)
string empty = String.Empty;
string[] tree = { empty, "/", "*", "10", "-", "+", empty, empty, "4", "2", "1", "3" };
//                     0     1    2     3    4    5     6      7     8    9    10   11
void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]); // Позиция вывода меняет способ обхода дерева. Вверх, вниз.
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();


// ---------------------------------------
// Task # 10
// Подсчет чисел Фибоначчи.


decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
//# 1 2 3 4 5 6
//V 1 1 2 3 5 8
Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 1; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"),-15}");
    fIte = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
Console.ReadLine();
DateTime dt = DateTime.Now;
for (int n = 1; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


// --------------------------------------------
// Task # 11
// Закрашивание картинки.


int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    pic[0, i] = 1;
    pic[i, 0] = 1;
    pic[i, 9] = 1;
    pic[9, i] = 1;
}

PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine;
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}