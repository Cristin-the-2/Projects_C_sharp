// Принимает число А и выдает сумму чисел от 1 до А.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }
    return sum;
}

int number = ReadInt("Введите число А: ");
Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}.");

number = ReadInt("Введите число B: ");
Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}.");

number = ReadInt("Введите число C: ");
Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}.");