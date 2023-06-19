// Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int n)
{
    if (n==0) return 0;
    return n%10 + SumNumber(n/10);
}

Console.WriteLine($"Сумма цифр числа: {SumNumber(ReadInt("Введите число: "))}");