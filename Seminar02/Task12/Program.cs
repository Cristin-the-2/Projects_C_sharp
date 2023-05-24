// Программа принимает два числа и выводит является ли второе число кратное первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления

Console.Write("Введите первое число: ");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondN = Convert.ToInt32(Console.ReadLine());

if(secondN % firstN == 0)
{
    Console.WriteLine($"Число {secondN} кратно {firstN}.");
}
else
{
    Console.WriteLine($"Число {secondN} не кратно {firstN}, остаток от деления {(secondN % firstN)}.");
}