/*
Задача 64: 
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
Console.WriteLine("Введите число -m- :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число -n- :");
int n = int.Parse(Console.ReadLine());

// Рекурсивный мнтод
void NaturalNumberLineMN(int start, int stop)
{
    if (start > stop) return;

    else
    {
        Console.Write(start + " ");
        NaturalNumberLineMN(++start, stop);
    }
}
// Обычный метод
void NaturalNumberLineMN2(int start, int stop)
{
    for (int i = start; i <= stop; i++) Console.Write(i + " ");
}

Console.WriteLine("Рекурсивный метод:");
NaturalNumberLineMN(m, n);
Console.WriteLine();
Console.WriteLine("Обычный метод:");
NaturalNumberLineMN2(m, n);