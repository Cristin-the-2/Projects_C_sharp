//Программа принимает два числа и проверяет является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго!");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго :-(");
}