// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов от 1 до N.

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(number > 0)
{
    for(int i = 1; i <= number; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
}
else
{
    Console.Write("Введено неверное значение!)");
}
Console.WriteLine();