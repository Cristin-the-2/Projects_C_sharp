// Программа принимает на вход число и выдает сумму цифр в числе

// int способ
int ReadInt(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int SymbolsCount(int n)
{
    int i = 0;
    if (n != 0)
    {
        while (n > 0)
        {
            n = n / 10;
            i++;
        }
    }
    else i = 1;
    return i;
}

int number = ReadInt("Введите число: ");
int count = SymbolsCount(number);
double sum = 0;
for (int i = count; i > 0; i--)
{
    sum = Math.Truncate(sum + (number % Math.Pow(10, i)) / Math.Pow(10, i - 1));
}

Console.WriteLine($"Сумма цифр числа = {sum}");

//string способ
string ReadString(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

string number1 = ReadString("Введите положительное число: ");
double sum1 = 0;
for (int i = 0; i < number1.Length; i++)
{
    sum1 = sum1 + char.GetNumericValue(number1[i]);
}

Console.WriteLine($"Сумма цифр числа = {sum1}");