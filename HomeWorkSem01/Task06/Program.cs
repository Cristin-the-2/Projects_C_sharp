// Программа принимает число и выдает является ли число четным

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Число является нулем");
}
else
{
    if (a % 2 == 0)
    {
        Console.WriteLine("Число является четным");
    }
    else
    {
        Console.WriteLine("Число является нечетным");
    }
}