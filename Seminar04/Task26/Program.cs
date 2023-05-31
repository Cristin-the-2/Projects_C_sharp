// Программа принимает на вход число и выдает количество цифр в числе

// 1 способ
string? ReadStr(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string? str = ReadStr("Введите число: ");
Console.WriteLine($"В числе {str} {str.Length} цифр.");

// 2 способ
int ReadInt(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SymbolsCount(int N)
{
    int i = 0;
    if (N != 0)
    {
        while (N > 0)
        {
            N = N / 10;
            i++;
        }
    }
    else i = 1;
    return i;
}

int number = ReadInt("Введите число: ");
Console.WriteLine($"В числе {SymbolsCount(number)} цифр.");