// Найти наибольшее из трех введенных чисел

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if ((a == b) && (b == c))
{
    Console.WriteLine("Числа между собой равны");
}
else
{
    if (max < b)
    {
        max = b;
    }
    if (max < c)
    {
        max = c;
    }
    Console.WriteLine($"Число {max} наибольшее.");
}