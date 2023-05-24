// Программа принимает на вход число и проверят, кратно ли оно 7 и 23 одновременно

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if((n % 7 == 0)&&(n % 23 == 0))
{
    Console.WriteLine($"Число {n} кратно 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {n} не кратно 7 и 23 одновременно");
}