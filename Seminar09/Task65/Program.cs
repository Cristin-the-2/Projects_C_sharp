// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int start, int finish)
{
    if (start == finish - 1) return;
    PrintNumber(start - 1, finish);
    Console.Write($"{start} ");
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M < N)
{
    PrintNumber(N, M);
}
else
{
    PrintNumber(M, N);
}