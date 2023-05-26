// Программа по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string[] strArray = {"X > 0 Y > 0", "X < 0 Y > 0", "X < 0 Y < 0", "X > 0 Y < 0", "Такой четверти нет"};
// if (quarter == 1)
// {
//     Console.WriteLine(strArr[0]);
// }
// else if (quarter == 2)
// {
//     Console.WriteLine(strArr[1]);
// }
// else if (quarter == 3)
// {
//     Console.WriteLine(strArr[2]);
// }
// else if (quarter == 4)
// {
//     Console.WriteLine(strArr[3]);
// }
// else
// {
//     Console.WriteLine(strArr[4]);
// }

if(quarter > 0 && quarter < 5)
{
    Console.WriteLine(strArray[quarter-1]);
}
else
{
    Console.WriteLine(strArray[4]);
}