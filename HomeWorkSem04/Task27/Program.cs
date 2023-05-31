// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReadInt(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SymbolsCount(int number)
{
    int i = 0;
    if (number != 0)
    {
        while (number > 0)
        {
            number = number / 10;
            i++;
        }
    }
    else i = 1;
    return i;
}

double SumSymbols(int number)
{
    double s = 0;
    for (int i = 1; i <= SymbolsCount(number); i++)
    {
        s = Math.Truncate(s + number % Math.Pow(10, i) / Math.Pow(10, i - 1));
    }
    return s;
}

int my_number = ReadInt("Введите число: ");
Console.WriteLine($"Сумма цифр в числе {SumSymbols(my_number)}.");