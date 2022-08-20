/*
Задача 68: 
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
*/

// string[] input = Console.ReadLine().Split(",");
// int m = int.Parse(input[0]);
// int n = int.Parse(input[1]);
Console.WriteLine("Введите значение -m- :");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение -n- :");
int n = int.Parse(Console.ReadLine());


int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}

Console.WriteLine("Функция Аккермана:" + $"\nA({m},{n}) = {FunctionAkkerman(m,n)}");