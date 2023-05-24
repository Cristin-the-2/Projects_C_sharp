// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        {
            Console.WriteLine("Будний день :-(");
            break;
        }
    case 6:
    case 7:
        {
            Console.WriteLine("Выходной день! :-)");
            break;
        }
    default:
        {
            Console.WriteLine("Такого дня недели не существует.");
            break;
        }
}