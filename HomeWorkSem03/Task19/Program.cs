//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] arr_number = new int[5];
arr_number[0] = number / 10000;
arr_number[1] = (number / 1000) % 10;
arr_number[2] = (number / 100) % 10;
arr_number[3] = (number / 10) % 10;
arr_number[4] = number % 10;
if (number > 9999 && number < 100000)
{
    if (arr_number[0] == arr_number[4] && arr_number[1] == arr_number[3])
    {
        Console.WriteLine("N полиндромное число");
    }
    else
    {
        Console.WriteLine("N не полиндромное число");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным!");
}