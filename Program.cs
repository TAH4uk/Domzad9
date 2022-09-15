// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={M}, M={N}");

if (M < N)
{
    Console.Write($"Все натуральные числа в промежутке от {M} до {N}:");
    for (int i = M; i <= N; i++)
    {
        Console.Write($" [{i}]");
    }
}
else
{
    Console.Write($"Все натуральные числа в промежутке от {N} до {M}:");
    for (int i = N; i <= M; i++)
    {
        Console.Write($" [{i}]");
    }
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N={M}, M={N}");

int sum = 0;
if (M > N)
{
    for (int i = N; i <= M; i++)
    {
        sum += i;
    }
    Console.Write($"Сумма всех натуральных чисел от {N} до {M} равна {sum}.");
}
else
{
    for (int i = M; i <= N; i++)
    {
        sum += i;        
    }
    Console.Write($"Сумма всех натуральных чисел от {M} до {N} равна {sum}.");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.

Console.Write("Введи M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {M}, n = {N} - > A(M,N) = {Akkerman(M, N)} ");

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}