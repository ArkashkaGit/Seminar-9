/*
Задача 66: 
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

написать рекурсию и обычным методом
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите число -m- : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число -n- : ");
int n = int.Parse(Console.ReadLine());

// Обычный метод
int SummaNaturalNumbersNM(int start, int stop)
{
    int summa = 0;

    while (true)
    {
        if (start <= stop)
        {
            summa += start;
            start++;
        }
        
        else return summa;
    }
}
// Рекурсивный метод
int SummaNaturalNumbersNM2(int start, int stop, int summa = 0)
{
    if (start > stop) return summa;

    else
    {
        summa += start;
        return SummaNaturalNumbersNM2(++start, stop, summa);
    }
}

Console.WriteLine("Обычный метод:");
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {SummaNaturalNumbersNM(m, n)}");
Console.WriteLine("Рекурсивный метод:");
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна: {SummaNaturalNumbersNM2(m, n)}");