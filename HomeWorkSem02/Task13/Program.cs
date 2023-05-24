// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (N > 99)
{
    while (N > 999)
    {
        N = N / 10;
    }
    Console.WriteLine($"Третья цифра введенного числа: {N % 10}.");
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}