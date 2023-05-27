// // "String"
// 'String'
// char s = 'f';
// string stroka = "5";
// // 0123456789...
// Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 5);

// string -> int (+)
// char -> int (-) (utf-8)
// char -> string -> int

// 2145235 = 2 + 1 + 4 + 5 + 2 + 3 +5 == 22
//  -2147000000 < int < 2147000000 

Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
int summa = 0;
for (int i = 0; i < number.Length; i++)
    summa = summa + Convert.ToInt32(number[i].ToString());
Console.WriteLine(summa);