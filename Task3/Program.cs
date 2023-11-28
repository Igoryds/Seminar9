// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AckermanFunction (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else 
    {
        if (n == 0) return AckermanFunction(m-1, 1);
        return AckermanFunction(m - 1, AckermanFunction(m, n-1));
    }
}

Console.WriteLine($"{AckermanFunction(M, N)}");