// Программа принимает на вход число Н и выдает квадраты чисел от 1 до Н

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(N > 0)
{
    for(int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 2)}, ");
    }
}
else
{
    Console.Write(Math.Pow(N, 2));
}
Console.WriteLine();