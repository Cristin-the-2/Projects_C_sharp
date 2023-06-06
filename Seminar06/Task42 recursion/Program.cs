// Программа преобразовывает десятичное число в двоичное (рекурсивный метод)

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int num)
{
    if (num == 0) return;
    GetBinaryView(num / 2);
    Console.Write(num % 2);
}

int number = ReadInt("Введите число: ");
GetBinaryView(number);
Console.WriteLine();