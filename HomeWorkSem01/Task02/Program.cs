// Программа принимает два числа и выдает какое число больше, а какое меньше

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < b)
{
    Console.WriteLine($"Число {b} больше чем {a}.");
}
else if (a > b)
{
    Console.WriteLine($"Число {a} больше чем {b}.");
}
else
{
    Console.WriteLine($"Число {a} равно числу {b}.");
}