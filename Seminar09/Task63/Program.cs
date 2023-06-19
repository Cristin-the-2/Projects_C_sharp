//  Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int number)
{
    if (number == 0) return;
    PrintNumber(number - 1);
    Console.Write($"{number} ");
}

PrintNumber(ReadInt("Введите число N: "));