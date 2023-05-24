//Программа принимает число Н и показывает все целые цисла от -Н до Н

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
// int M = -N;

// Console.Write("Все целые числа: ");
// while(M <= N)
// {
//     Console.Write($"{M}, ");
//     M ++;
// }
// Console.WriteLine();

if (N < 0)
{
    N = -N;
}

Console.Write("Все целые числа: ");
for (int i = -N; i <= N; i++)
{
    Console.Write($"{i}, ");
}
Console.WriteLine();