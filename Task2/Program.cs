// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) Console.WriteLine($"Число M больше N, введите другие значения");
else Console.WriteLine($"Сумма натуральных чисел в диапазоне от {M} до {N} равна\t{SumNumbers(M, N)}");

int SumNumbers (int start, int end)
{
    int sum = start;
    if (start == end) return sum;
    return (sum + SumNumbers(start + 1, end));
}

