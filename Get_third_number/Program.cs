// Получить третью цифру любого числа

Console.Write("Введите число: ");
string number = Console.ReadLine();
char[] arrnumber = number.ToCharArray();

if (arrnumber.Length < 3)
{
    Console.Write($"Третья цифра у числа {number} отсутсвует.");
}
else if (arrnumber[0].Equals('0'))
{
    int i = 1;
    while (arrnumber[i].Equals('0'))
    {
        i++;
    }
    Console.Write($"Третья цифра у числа {number}: {arrnumber[i + 2]}.");
}
else if (arrnumber[0].Equals('-'))
{
    int i = 1;
    while (arrnumber[i].Equals('-'))
    {
        i++;
    }
    while (arrnumber[i].Equals('0'))
    {
        i++;
    }
    Console.Write($"Третья цифра у числа {number}: {arrnumber[i + 2]}.");
}
else
{
    Console.Write($"Третья цифра числа {number}: {arrnumber[2]}.");
}