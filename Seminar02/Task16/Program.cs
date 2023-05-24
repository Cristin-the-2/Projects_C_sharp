// Программа принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.Write("Введите первое число: ");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondN = Convert.ToInt32(Console.ReadLine());

if((firstN == secondN * secondN) || (secondN == firstN * firstN))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}