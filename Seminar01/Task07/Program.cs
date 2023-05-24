// Программа принимает трехзначные числа и показывает последнюю цифру числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number < 99) || (number > 1000))
{
    Console.WriteLine("Число не является трехзначным!!!");
}
else
{
    int LastChar = number % 10;
    Console.WriteLine($"Последняя цифра числа: {LastChar}.");
}